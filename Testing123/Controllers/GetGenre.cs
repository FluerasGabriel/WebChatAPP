using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;

namespace Testing123.Controllers
{
    public class GetGenre
    {
       
        public List<Object> Genres()
        {
            var client = new RestClient("https://streaming-availability.p.rapidapi.com/genres");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "e0e1ebe40bmsh88e092450e215acp137ac9jsn23b2b4134b30");
            request.AddHeader("x-rapidapi-host", "streaming-availability.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
            List<Genre> genres;
        }
    }
}
