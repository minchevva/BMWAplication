using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Website.ViewModel;

namespace Website.Utils
{
    public class LoadDataUtil
    {
        private static readonly Uri url = new Uri("https://localhost:44394/api/Cars");
        //public static async Task<SelectList> LoadLocationDataAsync()
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = url;
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        // Add the Authorization header with the AccessToken.  + accessToken
        //        client.DefaultRequestHeaders.Add("Authorization", "Bearer ");

        //        // make the request
        //        HttpResponseMessage response = await client.GetAsync("");

        //        // parse the response and return the data.
        //        string jsonString = await response.Content.ReadAsStringAsync();
        //        var responseData = JsonConvert.DeserializeObject<List<LocationVM>>(jsonString);
        //        return new SelectList(responseData, "Id", "Name");
        //    }


        //}

        private static readonly Uri url2 = new Uri("https://localhost:44394/api/Sallemans");

        public static SelectList LoadCarsData()
        {
            var client = new WebClient();
            var body = "";

            body = client.DownloadString(url);
            var responseData = JsonConvert.DeserializeObject<List<CarVM>>(body);
            return new SelectList(responseData, "Id", "Name");
        }

        public static SelectList LoadSallemanData()
        {
            var client = new WebClient();
            var body = "";

            body = client.DownloadString(url2);
            var responseData = JsonConvert.DeserializeObject<List<SallemanVM>>(body);
            return new SelectList(responseData, "Id", "FirstName");

            //using (FilmReference.FilmClient service = new FilmReference.FilmClient())
            //{

            //    return new SelectList(service.GetFilms(), "idF", "Title");
            //}
        }
    }
}