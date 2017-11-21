using ApplicationCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationCrud.Controllers
{
    public class FuncionarioController : Controller
    {

        private ApplicationDbContext _context;

        public FuncionarioController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        
        // GET: Funcionario
        public ActionResult Index()
        {
            var funcionarios = _context.Funcionarios.ToList();
            return View(funcionarios);
        }

        public ActionResult Details(int id)
        {
            var funcionario = _context.Funcionarios.SingleOrDefault(f => f.Id == id);

            if(funcionario == null)
            {
                return HttpNotFound();
            }

            return View(funcionario);
        }

        public ActionResult New()
        {
            var funcionario = new Funcionario();

            return View("FuncionarioForm", funcionario);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Funcionario funcionario)
        {

            if (!ModelState.IsValid)
            {
                return View("FuncionarioForm", funcionario);
            }


            if (funcionario.Id == 0)
            {
                _context.Funcionarios.Add(funcionario);
            }
            else
            {
                var funcionarioInDb = _context.Funcionarios.Single(f => f.Id == funcionario.Id);

                funcionarioInDb.Nome = funcionario.Nome;
                funcionarioInDb.Cargo = funcionario.Cargo;
                funcionarioInDb.Email = funcionario.Email;
                funcionarioInDb.Telefone = funcionario.Telefone;
                funcionarioInDb.Matricula = funcionario.Matricula;

            }

            _context.SaveChanges();

            return RedirectToAction("Index");

        }

        public ActionResult Edit (int id)
        {
            var funcionario = _context.Funcionarios.SingleOrDefault(f => f.Id == id);

            if(funcionario == null)
            {
                return HttpNotFound();
            }

            return View("FuncionarioForm", funcionario);
        }


        public ActionResult Delete(int id)
        {
            var funcionario = _context.Funcionarios.SingleOrDefault(c => c.Id == id);

            if (funcionario == null)
                return HttpNotFound();

            _context.Funcionarios.Remove(funcionario);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200);
        }

    }
}