using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LockersHub.WebApp.Models;
using System.Net.Http;

namespace LockersHub.WebApp.Controllers
{
    public class LockerController : Controller
    {
        private readonly ILogger<LockerController> _logger;

        public LockerController(ILogger<LockerController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RentNow()
        {
            return View();
        }

        // GET: Lockers
        public async Task<ActionResult> GetAllLockers(string apiUrl)
        {
            var table = new List<LockerVM>();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    table = Newtonsoft.Json.JsonConvert.DeserializeObject<List<LockerVM>>(data);

                }


            }
            return PartialView("_SearchResult", table);

        }


        // GET: Lockers
        public async Task<ActionResult> GetLockersBySearch(string apiUrl)
        {
            var table = new List<LockerVM>();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    table = Newtonsoft.Json.JsonConvert.DeserializeObject<List<LockerVM>>(data);

                }


            }
            return PartialView("_SearchResult", table);

        }

        // GET: Lockers
        public async Task<List<string>> GetLockersBySearch2(string apiUrl)
       {
            List<string> table = null;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    table = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(data);
                }

            }
            return table;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
