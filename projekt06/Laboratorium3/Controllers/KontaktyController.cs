using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Laboratorium3.Models;



namespace Laboratorium3.Controllers
{
    public class KontaktyController : Controller
    {
        Notatnik n = new Notatnik();
        
        // GET: Kontakty
        public ActionResult Index()
        {
            return View(n.Kontakty);
        }
        [HttpPost]
        public ActionResult Index(string imie, string nazwisko, Kontakt.Grupa grupa)
        {
            List<Kontakt> wyszukane = new List<Kontakt>();


            foreach (Kontakt k in n.Kontakty){
                if ((k.Imie.Contains(imie) || imie.Equals("") || imie.Equals(null))
                        && (k.Nazwisko.Contains(nazwisko) || nazwisko.Equals("") || nazwisko.Equals(null)) &&
                        k.grupa.Equals(grupa))
                {
                    wyszukane.Add(k);
                }
            }

            return View(wyszukane);
        }

        // GET: Kontakty/Details/5
        public ActionResult Details(int id)
        {

            Kontakt kontakt = n.Kontakty.Single(k => k.Id == id);

            return View(kontakt);
        }

        // GET: Kontakty/Create
        public ActionResult Create()
        {
            ViewBag.Grupa = new SelectList(Enum.GetNames(typeof(Kontakt.Grupa)));
            return View();
        }

        // POST: Kontakty/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Kontakt kontakt = new Kontakt();
                kontakt.Id = (n.Kontakty.Count == 0) ? 0 : n.Kontakty.Last().Id + 1;
                UpdateModel(kontakt);
                n.Kontakty.Add(kontakt);
                n.Zapisz();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Kontakty/Edit/5
        public ActionResult Edit(int id)
        {
            Kontakt kontakt = n.Kontakty.Single(k => k.Id == id);
            ViewBag.Grupa = new SelectList(Enum.GetNames(typeof(Kontakt.Grupa)));
            return View(kontakt);
        }

        // POST: Kontakty/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Kontakt kontakt = n.Kontakty.Single(k => k.Id == id);
                UpdateModel(kontakt);
                n.Zapisz();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Kontakty/Delete/5
        public ActionResult Delete(int id)
        {
            Kontakt kontakt = n.Kontakty.Single(k => k.Id == id);
            return View(kontakt);
        }

        // POST: Kontakty/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Kontakt kontakt = n.Kontakty.Single(k => k.Id == id);
                n.Kontakty.Remove(kontakt);
                n.Zapisz();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

   
        
    }
}
