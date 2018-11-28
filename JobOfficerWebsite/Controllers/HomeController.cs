using JobOfficerWebsite.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace JobOfficerWebsite.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public ActionResult Index()
        {
            var list = context.Category.ToList();
            return View(list);
        }

        // action Details to show datails of Job
        public ActionResult Details(int JobId)
        {
            var job = context.Jobs.Find(JobId);
            if (job == null)
            {
                return HttpNotFound();
            }
            Session["JobId"] = JobId;
            return View(job);
        }
        // action to apply job
        //Get
        [Authorize]
        public ActionResult ApplyJob()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ApplyJob(string Message)
        {
            var UserId = User.Identity.GetUserId();
            var JobId = (int)Session["JobId"]; //     
            var check = context.ApplyForJobs.Where(a => a.JobId == JobId && a.UserId == UserId).ToList();
            if (check.Count < 1)
            {
                var job = new ApplyForJob();
                job.UserId = UserId;
                job.Message = Message;
                job.ApplyDate = DateTime.Now;
                job.JobId = JobId;
                context.ApplyForJobs.Add(job);
                context.SaveChanges();
                ViewBag.Result = "تمت الاضافة بنجاح ";
            }
            else
            {
                ViewBag.Result = " المعذرة لقد سبق وتقدمت الي نفس الوظيفة ";
            }
            return View();
        }

        // To Retrive All Job for user
        [Authorize]
        public ActionResult GetJobByUser()
        {
            var UserId = User.Identity.GetUserId();
            var Jobs = context.ApplyForJobs.Where(a => a.UserId == UserId);
            return View(Jobs.ToList());
        }

        //display detail of job (applied) 
        [Authorize]
        public ActionResult DetailsOfJob(int id)
        {
            var job = context.ApplyForJobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }
        // GET: ApplyforJob/Edit/5
        public ActionResult Edit(int id)
        {
            var role = context.ApplyForJobs.Find(id);
            if (role == null)
            {
                return HttpNotFound();
            }
            return View(role);
        }
        // POST: ApplyOfJob/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplyForJob job)
        {
            if (ModelState.IsValid)
            {
                job.ApplyDate = DateTime.Now;
                context.Entry(job).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("GetJobByUser");
            }
            return View(job);
        }

        // GET: GetJobByUser/Delete/5
        public ActionResult Delete(int id)
        {
            var job = context.ApplyForJobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // POST: Role/Delete/5
        [HttpPost]
        public ActionResult Delete(ApplyForJob jj)
        {

            // TODO: Add delete logic here
            var myJob = context.ApplyForJobs.Find(jj.Id);
            context.ApplyForJobs.Remove(myJob);
            context.SaveChanges();
            return RedirectToAction("GetJobByUser");

        }
        // view job who publish
        [Authorize(Roles = "الناشرون")]
        public ActionResult GetJobByPublisher()
        {
            var UserId = User.Identity.GetUserId();

            var jobs = from app in context.ApplyForJobs
                       join jj in context.Jobs
                       on app.JobId equals jj.Id
                       where jj.User.Id == UserId
                       select app;
            ////////////////
            var grouped = from j in jobs
                          group j by j.job.JobTitle
                         into gr
                          select new JobsViewModel
                          {
                              JobTitle = gr.Key,
                              Items = gr
                          };

            return View(grouped.ToList());
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Contact(ContactModel contact)
        {
            //try {
            // object for Message 
            var mail = new MailMessage();
            mail.From = new MailAddress(contact.Email);
            mail.To.Add(new MailAddress("azzaashry14@gmail.com"));
            mail.Subject = contact.Subject;
            mail.IsBodyHtml = true;
            string body = "اسم المرسل " + contact.Name + "<br/>" +
                        "بريد المرسل" + contact.Email + "<br/>" +
                        "عنوان الرسالة" + contact.Subject + "<br/>" +
                        "نص الرسالة" + contact.Message;
            mail.Body = body;
            //mail.Body = contact.Message;
            var smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            
            smtp.Credentials = new NetworkCredential("azzaashry14@gmail.com", "sabreen1991");
            smtp.EnableSsl = true;
            smtp.Send(mail);
            ViewBag.Message = "Thank you for concating us";
            //}
            //catch (Exception ex)
            //{
            //    ViewBag.Message = $" Sorry we are facing Problem here {ex.Message}";//}
           // return View(contact);
           return RedirectToAction("Index");
        }

        ///// search for jobs
        public ActionResult Search()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Search(string searchName)
        {
            var Result = context.Jobs.Where(a => a.JobTitle.Contains(searchName)
            || a.JobContent.Contains(searchName)
            || a.category.CategoryName.Contains(searchName)
            || a.category.CategoryDescription.Contains(searchName)).ToList();

            return View(Result);

        }
        //retrive all category
        public ActionResult GetAllCategory (Category cc)
        {
            List<Category> mycategory = context.Category.ToList();
            return View(mycategory);
            //var jj = context.Category.Include(a => a.CategoryName);
            //return View(jj.ToList());
            //var catlist = new Category
            //{
            //    CategoryName = cc.CategoryName,
            //    jobs = this.context.Jobs.ToList()

            //};
            //return View(catlist);

            //var catName = context.Category.Find(cc.CategoryName);
            //var categorylist = context.Jobs.Where(a => a.category==catName);

            //return View(categorylist.ToList());
        }
        public ActionResult CategoryName(int id)
        {
            //Job jj = new Job();

            var jobs  = context.Jobs.Where(a => a.catId == id).ToList();
            if (jobs !=null)
            {
                return View(jobs);
            }
            else
            {
                return Json(new { MessageType = "danger", ReturnMessage = ("Done") });
            }
            return View();
        }


    }
}