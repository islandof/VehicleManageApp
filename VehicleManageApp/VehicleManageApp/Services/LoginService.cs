using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VehicleManageApp.Services
{
    public class LoginService:ILoginService
    {
        public Task<bool> LoginAsync(string username, string password)
        {
            return Task.FromResult(Login(username,password));
        }

        private static bool Login(string username, string password)
        {
            //var client = new HttpClient();
            //client.BaseAddress= new Uri("http://cloud.tescar.cn/home/");
            //var response = client.GetAsync("LoginSubmit2?UserName=admin&Pwd=123&isspe=1");
            //var loginJson = response.Con
            //var rootobject = JsonConvert.DeserializeObject<root>()
            return true;
        }
    }
}
