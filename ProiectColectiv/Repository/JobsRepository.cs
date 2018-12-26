using ProiectColectiv.Data;
using ProiectColectiv.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace ProiectColectiv.Repository
{
    public class JobsRepository : GenericRepository<Job>, IJobsRepository
    {
        public JobsRepository(ApplicationDbContext dataContext) : base(dataContext)
        {
        }

        public IQueryable<Job> GetAvailableJobs()
        {
            return this.GetMany(job => job.AvailableUntil > DateTime.Now).OrderByDescending(job => job.PostedOn);
        }
    }
}
