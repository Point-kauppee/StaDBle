using StaDBleWebApp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using StaDBleWebApp.Models;
using StaDBleWebApp.Database;

namespace StaDBleWebApp.Controllers
{
    public class StaDBleController : Controller
    {
        // GET: StaDBle
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }

        // GET: StaDBle/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StaDBle/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AssignHorse()
        {
            string json = Request.InputStream.ReadToEnd();
            StableModel inputData = 
                JsonConvert.DeserializeObject<StableModel>(json);

            bool success = false;
            string error = "";

            StaDBleEntities entities = new StaDBleEntities();
            try
            {
                //haetaan tallin tunnisteen perusteella
                int stableId = (from s in entities.Stables
                                where s.Identifier == inputData.StableCode
                                select s.Id).FirstOrDefault();

                //haetaan hevosen tunnisteen perusteella
                int horseId = (from h in entities.Horses
                                where h.Identifier == inputData.HorseCode
                                select h.Id).FirstOrDefault();

                if ((stableId > 0 )&& (horseId >0))
                {
                    //talletetaan uusi rivi kantaan
                    Horse newEntry = new Horse();
                    newEntry.Id = horseId;

                    entities.Horses.Add(newEntry);
                    entities.SaveChanges();

                    success = true;
                }

            }

            catch (Exception ex)
            {
                error = ex.GetType().Name + ": " + ex.Message;
            }
            finally
            {
                entities.Dispose();
            }
            //palautetaan JSON-muotoinen tulos kutsujalle
            var result = new { success = success, error = error };
            return Json(result);

        }

        // POST: StaDBle/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StaDBle/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StaDBle/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StaDBle/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StaDBle/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
