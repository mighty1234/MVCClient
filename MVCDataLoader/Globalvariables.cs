using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MVCDataLoader
{
    class Globalvariables
    {

     
        public class GlobalVariables
        {
            public static HttpClient WebApiClient = new HttpClient();

            static GlobalVariables()
            {
                WebApiClient.BaseAddress = new Uri("http://localhost:57429/api/");
                WebApiClient.DefaultRequestHeaders.Clear();
                WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }
    
}
}
