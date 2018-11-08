using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProiectColectiv.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProiectColectiv.Controllers
{
    public class JobsController : Controller
    {
        private readonly IJobsService jobsService;

        public JobsController(IJobsService jobsService)
        {
            this.jobsService = jobsService;
        }

        // GET: /<controller>/
        public IActionResult Index(int page)
        {
            return View(jobsService.GetJobsViewModel(page));
        }


        // GET: /<controller>/
        public IActionResult Details(int id)
        {
            var jobVM = jobsService.GetDetailsJobViewModel(id);
            if (jobVM.Job == null)
            {
                return NotFound();
            }
            return View(jobVM);
        }
    }
}
