using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ElectronNET.API;
using System.IO;
using System.Threading.Tasks;

namespace GATE.ElectronUI.Controllers
{
    public class CoreController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> GetFileContent(string FilePath)
        {
            string path = Path.Combine(@"C:\TFS\Tools\MakatiProjects\GATE\SeleniumCostpoint\TestRuns", FilePath);
            string content = await System.IO.File.ReadAllTextAsync(path);
            return Json(content);
        }

        public IActionResult Index()
        {

            if (HybridSupport.IsElectronActive)
            {
                Electron.IpcMain.On("preview-code", (args) =>
                {
                    //TODO: Get full filepath and use instead of constructing on the fly here...
                    //string path = Path.Combine(@"C:\TFS\Tools\MakatiProjects\GATE\SeleniumCostpoint\Tests\CP_SMOKE\MM\", args.ToString().Trim(' ') + ".cs");
                    ///string display = await System.IO.File.ReadAllTextAsync(path);
                    string title = args.ToString().Trim(' ');
                    var mainWindow = Electron.WindowManager.BrowserWindows.First();
                    Electron.IpcMain.Send(mainWindow, "preview-code-text-reply", title);
                });

            }

            return View();
        }

    }
}