using Microsoft.AspNetCore.Hosting.Server;

namespace ConfigurationsHomeWork1.ConfogurationModel
{
    public class ConnectionModel
    {
        public string ConnectionString { get; set; }

        public string Login {  get; set; }

        public IEnumerable<ServersModel> Servers { get; set; }

        public  IDictionary<string, InternetModel> Internet {  get; set; }


        //public IDictionary<string, ProfileData> Profiles { get; set; }

    }
}
