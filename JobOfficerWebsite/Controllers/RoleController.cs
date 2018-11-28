using JobOfficerWebsite.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobOfficerWebsite.Controllers
{
    [Authorize(Roles = "Admins")]
    public class RoleController : Controller
    {

        ApplicationDbContext context = new ApplicationDbContext();
        // GET: Role
        public ActionResult Index()
        {

            return View(context.Roles.ToList());
        }

        // GET: Role/Details/5
        public ActionResult Details(string id)
        {
            var role = context.Roles.Find(id);
            if(role==null)
            {
                return HttpNotFound();
            }
            return View(role);
        }

        // GET: Role/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Role/Create
        [HttpPost]
        public ActionResult Create(IdentityRole role)
        {
            if(ModelState.IsValid)
            {
                context.Roles.Add(role);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(role);
  
        }

        // GET: Role/Edit/5
        public ActionResult Edit(string id)
        {
            var role = context.Roles.Find(id);
            if(role==null)
            {
                return HttpNotFound();
            }
            return View(role);
        }

        // POST: Role/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind (Include="Id,Name")] IdentityRole role)
        {
            if (ModelState.IsValid)
            {
                context.Entry(role).State =EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(role);
        }

        // GET: Role/Delete/5
        public ActionResult Delete(string id)
        {
            var role = context.Roles.Find(id);
            if (role==null)
            {
                return HttpNotFound();
            }
            return View(role);
        }

        // POST: Role/Delete/5
        [HttpPost]
        public ActionResult Delete(IdentityRole role)
        {
            
                // TODO: Add delete logic here
                var myRole = context.Roles.Find(role.Id);
                context.Roles.Remove(myRole);
                context.SaveChanges();
                return RedirectToAction("Index");
          
        }
    }
}
