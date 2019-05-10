using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Logic.Service
{
    public class CloudService
    {
        RestClient client;
        string access_token;

        public CloudService()
        {
            client = new RestClient("");

        }
        public async Task Login()
        {
            var request = new RestRequest("", Method.GET);
            request.AddParameter("Authorization", string.Format("Bearer " + access_token),ParameterType.HttpHeader);
            var response = await client.ExecuteTaskAsync<HttpResponse>(request);
        }
    }
}
