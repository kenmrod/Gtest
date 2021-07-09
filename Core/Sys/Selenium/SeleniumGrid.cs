
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Core.Sys.Selenium
{
    public class SeleniumGrid
    {
        #region Private Props
        //public static readonly HttpClient Client = new HttpClient();
        private string Uri { get; set; }

        #endregion

        #region Public Props

        public static Action<string> Infologger { get; set; }
        public static Action<string> Errlogger { get; set; }

        #endregion

        #region Contructor

        public SeleniumGrid(string Uri) => this.Uri = Uri;

        #endregion

        #region Unused Methods

        public List<Node> GetNodes()
        {
            var grid = GetGridHub();

            return grid?.Value.Nodes;
        }

        public int GetNodeCapacity(Node node, BrowserType browser)
        {
            int totalCapacity = 0;

            foreach (var s in node?.Stereotypes)
            {
                var cap = s["capabilities"];

                var count = s["count"];

                if (cap == null) break;

                string browserName = cap["browserName"];

                if (browserName == GetBrowserTypeName(browser))
                    totalCapacity += count;
            }

            return totalCapacity;
        }

        private string GetBrowserTypeName(BrowserType browser) => browser.ToString().ToLower();


        public int GetNodeCapacity(string nodeId, BrowserType browser)
        {
            var node = GetNodes().FirstOrDefault(n => n.Id == nodeId);
            if (node == null) Log($"cannot found node with id ({nodeId})");
            return GetNodeCapacity(node, browser);
        }

        public int GetTotalCapacity(List<Node> nodes, BrowserType browser)
        {
            int totalCapacity = 0;
            nodes?.ForEach(node =>
            {
                totalCapacity += GetNodeCapacity(node, browser);
            });
            return totalCapacity;
        }

        public int GetTotalCapacity(BrowserType browser) =>
            GetTotalCapacity(GetNodes(), browser);


        public List<Session> GetNodeSessions(string nodeId)
        {
            var node = GetNodes().FirstOrDefault(n => n.Id == nodeId);
            return node?.Sessions;
        }


        public int GetNodeSessionCount(string nodeId)
        {
            var node = GetNodes().FirstOrDefault(n => n.Id == nodeId);
            return node == null ? 0 : node.Sessions.Count;
        }

        public int GetTotalSessionCount(List<Node> nodes = null)
        {
            int totalSessions = 0;
            (nodes == null ? GetNodes() : nodes).ForEach(node =>
            {
                if (node.Sessions != null)
                    totalSessions += node.Sessions.Count();
            });

            return totalSessions;
        }

        public Node GetAvailableNode(BrowserType browser)
        {
            try
            {
                foreach (var n in GetNodes())
                    if (GetNodeCapacity(n, browser) > n.Sessions.Count) 
                        return n;

                return null;
            }
            catch (Exception e)
            {
                HandleErr(e);
                return null;
            }
        }

        public string GetHostName(SessionId sessionId, int port = 5555)
        {
            foreach(var node in GetNodes())
            {
                var session = node.Sessions.FirstOrDefault(s => s.SessionId == sessionId.ToString());
                if (session != null)
                    return new Uri(node.Uri).Host;
            }
            return null;
        }
        
        private GridHub GetGridHub()
        {
            var gridUri = Uri.TrimEnd('/') + "/status";

            try
            {
                var client = new RestClient(gridUri);
                var response = client.Execute<GridHub>(new RestRequest());
                return response.Data;
            }
            catch (NotSupportedException e)
            {
                HandleErr(e, "The content type is not supported.");
            }
            catch (Exception e)
            {
                HandleErr(e, $"Problem encountered while communicating to the GRID {gridUri}");
            }

            return null;
        }

        #endregion

        #region Used Methods

        /// <summary>
        /// Gets the current state of the grid as GridState class object and register it as a session if the grid becomes ready.
        /// </summary>
        /// <param name="hostName">Host name or machine name where the load balancer is deployed</param>
        /// <param name="testId">test id to be registered if the grid state is ready</param>
        /// <param name="batchId">batch id to be registered if the grid state ready</param>
        /// <returns>Grid State class object</returns>
        public static GridState GetGridState(string hostName, string testId, string batchId)
        {
            var gridUri = $"http://{hostName}:4440/grid";

            try
            {
                var client = new RestClient(gridUri);
                var request = new RestRequest(Method.POST);
                request.AddHeader("Accept", "application/json");
                var body = new { testId, batchId };
                request.AddJsonBody(body);

                var response = client.Execute<GridState>(request);
                return response.Data;
            }
            catch (NotSupportedException e)
            {
                HandleErr(e, "The content type is not supported.");
            }
            catch (Exception e)
            {
                HandleErr(e, $"Problem encountered while communicating to the GRID {gridUri}");
            }

            return null;
        }

        /// <summary>
        /// Removes the session with the given session id
        /// </summary>
        /// <param name="hostName">Host name or machine name where the load balancer is deployed</param>
        /// <param name="id">Session ID</param>
        /// <returns>True if it successfully deletes the session and false otherwise</returns>
        public static bool RemoveSession(string hostName, string id)
        {
            var gridUri = $"http://{hostName}:4440/grid";

            try
            {
                var client = new RestClient(gridUri);
                var request = new RestRequest(Method.DELETE);
                request.AddHeader("Accept", "application/json");
                var body = new { id };
                request.AddJsonBody(body);

                var response = client.Execute<DeleteSession>(request);
                return response.Data.Success;
            }
            catch (NotSupportedException e)
            {
                HandleErr(e, "The content type is not supported.");
            }
            catch (Exception e)
            {
                HandleErr(e, $"Problem encountered while communicating to the GRID {gridUri}");
            }

            return false;
        }

        /// <summary>
        /// Gets the total current capacity of Selenium Grid
        /// </summary>
        /// <param name="hostName">Host name or machine name where the load balancer is deployed</param>
        /// <returns>GridCapacity class object</returns>
        public static GridCapacity GetCapacity(string hostName)
        {
            var gridUri = $"http://{hostName}:4440/grid/capacity";

            try
            {
                var client = new RestClient(gridUri);
                var response = client.Execute<GridCapacity>(new RestRequest());
                return response.Data;
            }
            catch (NotSupportedException e)
            {
                HandleErr(e, "The content type is not supported.");
            }
            catch (Exception e)
            {
                HandleErr(e, $"Problem encountered while communicating to the GRID {gridUri}");
            }

            return null;
        }

        /// <summary>
        /// Returns the test session information of the session id provided from the body of the post request.
        /// </summary>
        /// <param name="hostName"></param>
        /// <param name="sessionId"></param>
        /// <returns>TestSession class object</returns>
        public static TestSession GetTestSession(string hostName, string sessionId)
        {
            var gridUri = $"http://{hostName}:4440/grid/sessionid";

            try
            {
                var client = new RestClient(gridUri);
                var request = new RestRequest(Method.POST);
                request.AddHeader("Accept", "application/json");
                var body = new { sessionId };
                request.AddJsonBody(body);

                var response = client.Execute<TestSession>(request);
                return response.Data;
            }
            catch (NotSupportedException e)
            {
                HandleErr(e, "The content type is not supported.");
            }
            catch (Exception e)
            {
                HandleErr(e, $"Problem encountered while communicating to the GRID {gridUri}");
            }

            return null;
        }

        /// <summary>
        /// Success logger method
        /// </summary>
        /// <param name="message"></param>
        private static void Log(string message) => Infologger?.Invoke(message);

        /// <summary>
        /// Error logger method
        /// </summary>
        /// <param name="message"></param>
        private static void Err(string message) => Errlogger?.Invoke(message);

        /// <summary>
        /// Error handler method
        /// </summary>
        /// <param name="e">Exception object</param>
        /// <param name="message">message to be logged. null by default</param>
        private static void HandleErr(Exception e, string message = null)
        {
            Err(message);
            Err(e.Message);
            Err(e.StackTrace);
        }

        #endregion
    }

    public enum BrowserType
    {
        Chrome,
        FireFox
    }

    public class GridState
    {
        public bool Ready { get; set; }
        public int SessionCount { get; set; }
        public DataSession Data { get; set; }
        public string Err { get; set; }
    }
    public class DataSession
    {
        public string Id { get; set; }
        public string TestId { get; set; }
        public string BatchId { get; set; }
    }

    public class DeleteSession
    {
        public bool Success { get; set; }
    }

    public class TestSession
    {
        public bool Success { get; set; }
        public string Hostname { get; set; }
        public string Port { get; set; }
    }
    public class GridCapacity
    {
        public int Capacity { get; set; }
    }
}
