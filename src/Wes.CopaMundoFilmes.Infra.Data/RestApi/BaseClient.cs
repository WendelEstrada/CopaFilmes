using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Wes.CopaMundoFilmes.Infra.Data.RestApi
{
    internal class BaseClient<T> where T : class
    {
        private HttpClient client;

        public T Dados { get; private set; }

        internal void RealizarChamada()
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["apiFilmes"]);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = client.GetAsync(client.BaseAddress).Result;

                    if (response.IsSuccessStatusCode)
                        Dados = response.Content.ReadAsAsync<T>().Result;
                }

                catch (Exception)
                {
                    throw;
                };
            }
        }
    }
}
