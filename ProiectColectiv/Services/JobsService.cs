using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProiectColectiv.Repository;
using ProiectColectiv.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectColectiv.Services
{
    public class JobsService : IJobsService
    {
        private readonly IJobsRepository jobsRepository;
        private readonly IConfiguration configuration;
        public JobsService(IJobsRepository jobsRepository, IConfiguration configuration)
        {
            this.jobsRepository = jobsRepository;
            this.configuration = configuration;
        }


        public JobsViewModel GetJobsViewModel(int page)
        {
            var jobs = jobsRepository.GetAvailableJobs();
            var totalJobs = jobs.Count();
            var jobsInPage = configuration.GetValue<int>("JoinsInPage");
            return new JobsViewModel()
            {
                CurrentPage = page,
                TotalPages = totalJobs / jobsInPage + ((totalJobs % jobsInPage == 0) ? 0 : 1),
                Jobs = jobs.Skip((page - 1) * jobsInPage).Take(jobsInPage).ToList()
            };
        }

        public DetailsJobViewModel GetDetailsJobViewModel(int id)
        {
            return new DetailsJobViewModel()
            {
                Job = jobsRepository.Get(job => job.Id == id)
            };
        }
    }
}
