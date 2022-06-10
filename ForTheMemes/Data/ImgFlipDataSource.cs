using System;
using System.Net.Http;
using Refit;

namespace ForTheMemes.Data
{
    public class ImgFlipDataSource : IImgFlipDataSource
    {
        private readonly Lazy<IImgFlipApi> client;

        public ImgFlipDataSource(string baseAddress)
        {
            IImgFlipApi CreateClient(HttpMessageHandler messageHandler)
            {
                var httpClient = new HttpClient(messageHandler)
                {
                    BaseAddress = new Uri(baseAddress)
                };

                return RestService.For<IImgFlipApi>(httpClient);
            }

            //TODO: replace with logging handler
            client = new Lazy<IImgFlipApi>(() => CreateClient(new HttpClientHandler()));
        }

        public IImgFlipApi Client => client.Value;
    }
}