using ConfigurationsHomeWork1.ConfogurationModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic.FileIO;

namespace ConfigurationsHomeWork1.Controllers
{
    public class ConfigurationController : Controller
    {
        public ConfigurationController(IOptionsSnapshot<ConnectionModel> connectInfo) 
        {
            ConnectionModel = connectInfo;
        }

        public IOptionsSnapshot<ConnectionModel> ConnectionModel { get; set; }
     
        public IActionResult ShowDataFromConfiguration()
        {
            ConnectionModel mod = new ConnectionModel();
            mod.ConnectionString = ConnectionModel.Value.ConnectionString;
            mod.Login = ConnectionModel.Value.Login;
            mod.Internet = ConnectionModel.Value.Internet;
            mod.Servers = ConnectionModel.Value.Servers;
            
            return View(mod);
        }
    }
}
