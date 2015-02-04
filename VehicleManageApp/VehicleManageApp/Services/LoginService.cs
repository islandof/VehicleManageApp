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
            var response = await client.GetAsync("LoginSubmit2?UserName="+username+"&Pwd="+password+"&isspe=1");
            var loginJson =  response.Content.ReadAsStringAsync().Result;
            var user = JsonConvert.DeserializeObject<LoginViewModel>(loginJson);
            if (user.USER_ID != 0)
            {
                return true;    
            }
            return false;
        }

        
    }
}
