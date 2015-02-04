using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using VehicleManageApp.ViewModels;

namespace VehicleManageApp.Services
{
    public class LoginService:ILoginService
    {
        public async Task<bool> LoginAsync(string username, string password)
        {
            var client = new HttpClient {BaseAddress = new Uri("http://cloud.tescar.cn/home/")};
            var response = await client.GetAsync("LoginSubmit2?UserName=admin&Pwd=123&isspe=1");
            var loginJson =  response.Content.ReadAsStringAsync().Result;
            var rootobject = JsonConvert.DeserializeObject<LoginViewModel>(loginJson);
            return true;
        }

        
    }
}
