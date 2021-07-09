using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Sys.Selenium
{
    public class GridNode
    {
        public NodeInfo Value { get; set; }
    }

    public class NodeInfo
    {
        public bool Ready { get; set; }
        public string Message { get; set; }
        public GridNode Node { get; set; }
    }

    public class Node
    {
        public string Id { get; set; }
        public string Uri { get; set; }
        public int MaxSessions { get; set; }

        [JsonConverter(typeof(SingleOrArrayConverter<dynamic>))]
        public List<dynamic> Stereotypes { get; set; }
        //public List<Slot> Slots { get; set; }
        public List<Session> Sessions { get; set; }
        public string Warning { get; set; }
    }

    public class Slot
    {
        public string LastStarted { get; set; }
        public Session Session { get; set; }
        public Stereotype Stereotype { get; set; }
    }

    public static class NodeExt
    {
        public static List<Stereotype> GetStereotypes(this Node node)
        {
            List<Stereotype> stereotypes = new List<Stereotype>();
            try
            {
                //var sample = JsonConvert.SerializeObject(node.Stereotypes);
                //var sample2 = JsonConvert.DeserializeObject<List<Stereotype>>();
            }
            catch(Exception e) { }

            return stereotypes;
        }
    }

    public class Session
    {
        public string SessionId { get; set; }
        //public Capabilities CurrentCapabilities { get; set; }
    }

    //public class Stereotype
    //{
    //    public string BrowserName { get; set; }
    //}

    public class Stereotype
    {
        public Capabilities Capabilities { get; set; }
        public int Count { get; set; }
    }

    public class Capabilities
    {
        public string BrowserName { get; set; }
    }

    public class SingleOrArrayConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(List<T>));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Array)
            {
                return token.ToObject<List<T>>();
            }
            return new List<T> { token.ToObject<T>() };
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
