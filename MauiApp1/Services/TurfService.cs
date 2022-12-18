using MauiApp1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    internal class TurfService : ITurfRepository
    {

        public static readonly string baseUrl = "https://localhost:7276/api";



        public async Task<bool> AddUpdateTurfAsync(TurfInfo turf)
        {
            String json = JsonConvert.SerializeObject(turf);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();

            // throw new NotImplementedException();
            if (turf.Id == 0)
            {
 
                string url = baseUrl + "/turfs";
                client.BaseAddress = new Uri(url);
                HttpResponseMessage responseMessage = await client.PostAsync("", content);

                if (responseMessage.IsSuccessStatusCode)
                {
                    return await Task.FromResult(true);
                }             
            }
            // use different Fucn for Update.
            else
            {
                string url = baseUrl + "/turfs/{id}";
                client.BaseAddress = new Uri(url);
                HttpResponseMessage responseMessage = await client.PostAsync("", content);

                if (responseMessage.IsSuccessStatusCode)
                {
                    return await Task.FromResult(true);
                }
            }
            return await Task.FromResult(true);

        }

        public async Task<bool> DeleteTurfAsync(int id)
        {
            // throw new NotImplementedException();

            HttpClient client = new HttpClient();
            string url = baseUrl + "/turfs/"+id;
            client.BaseAddress = new Uri(url);
            HttpResponseMessage responseMessage = await client.DeleteAsync("");

            if (responseMessage.IsSuccessStatusCode)
            {
                return await Task.FromResult(true);
            }
            else
            {
                return await Task.FromResult(false);
            }

        }
        public async Task<TurfInfo> GetTurfAsync(int id)
        {
            // throw new NotImplementedException();

            var t = new TurfInfo();
            HttpClient client = new HttpClient();
            string url = baseUrl + "/turfs/" + id;
            client.BaseAddress = new Uri(url);
            HttpResponseMessage responseMessage = await client.GetAsync("");

            if (responseMessage.IsSuccessStatusCode)
            {
                t = await responseMessage.Content.ReadFromJsonAsync<TurfInfo>();
            }
            return await Task.FromResult(t);

        }

        public Task<IEnumerable<TurfInfo>> GetProductAsync()
        {
            // throw new NotImplementedException();
            // var t
            return null;
        }


    }
}
