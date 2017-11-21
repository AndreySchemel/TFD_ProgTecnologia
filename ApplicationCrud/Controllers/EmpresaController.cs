﻿using ApplicationCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationCrud.Controllers
{
    public class EmpresaController : Controller
    {

        private ApplicationDbContext _context;

        public EmpresaController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Empresa
        public ActionResult Index()
        {
            var empresas = _context.Empresas.ToList();
            return View(empresas);
        }

        public ActionResult Details(int id)
        {
            var empresa = _context.Empresas.SingleOrDefault(e => e.Id == id);
            if(empresa == null)
            {
                return HttpNotFound();
            }
            return View(empresa);

        }

        public ActionResult New()
        {
            var empresa = new Empresa();

            return View("EmpresaForm", empresa);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Empresa empresa)
        {

            if (!ModelState.IsValid)
            {
                return View("EmpresaForm", empresa);
            }

            if (empresa.Id == 0)
            {
                _context.Empresas.Add(empresa);
            } 
            else
            {
                var empresaInDb = _context.Empresas.Single(e => e.Id == empresa.Id);

                empresaInDb.NomeEmpresa = empresa.NomeEmpresa;
                empresaInDb.NumeroTelefone = empresa.NumeroTelefone;
                empresaInDb.Cnpj = empresa.Cnpj;
                empresaInDb.Endereco = empresa.Endereco;
                empresaInDb.CapitalSocial = empresa.CapitalSocial;
                empresaInDb.TipoEmpresa = empresaInDb.TipoEmpresa;

            }

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {

            var empresa = _context.Empresas.SingleOrDefault(e => e.Id == id);

            if(empresa == null)
            {
                return HttpNotFound();
            }

            return View("EmpresaForm", empresa);
        }

        public ActionResult Delete(int id)
        {
            var empresa = _context.Empresas.SingleOrDefault(c => c.Id == id);

            if (empresa == null)
                return HttpNotFound();

            _context.Empresas.Remove(empresa);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200);
        }
    }
}