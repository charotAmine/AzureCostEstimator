using costEstimator.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


namespace costEstimator.Controllers
{
    public class PricerController : Controller
    {
        private readonly IConfiguration configuration;
        public PricerController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // GET: PricerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PricerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PricerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PricerController/Create
        [HttpPost]
        public async Task<ActionResult> SaveUploadedFileAsync(IFormFile file)
        {
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                var fileContent = reader.ReadToEnd();
                var parsedContentDisposition = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
                var content = new StringContent(fileContent, Encoding.UTF8, "application/json");
                HttpClient client = new HttpClient();
                string functionUrl = "https://azurecostestimator-back.azurewebsites.net/api/azurecostestimator-general?code=05Vfvhpm/PMT0rqzawHaWHvl3Lt8jA7DdlrpcTRVsSmvqTuAHww2kw==";
                var response = await client.PostAsync(functionUrl, content);
                string result = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<PricerModel>>(result);

                return Json(new { Message = list });

            }


        }

        // GET: PricerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PricerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PricerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PricerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
