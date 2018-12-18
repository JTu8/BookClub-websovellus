using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookAppMVC.Models;
using System.Net.Http;
using System.Net.Http.Formatting;

namespace BookAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Books> _books = null;

            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:50644/api/Books");
                var responseTask = client.GetAsync("books");
                responseTask.Wait();

                var result = responseTask.Result;
                if(result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Books>>();
                    _books = readTask.Result;
                }
                else
                {
                    _books = Enumerable.Empty<Books>();
                    ModelState.AddModelError(string.Empty, "Virhe tietokannassa");
                }
            }

            return View(_books);
        }

        
    }
}
