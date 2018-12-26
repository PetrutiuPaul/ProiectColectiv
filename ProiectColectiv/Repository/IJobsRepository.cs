using System.Collections.Generic;
using System.Linq;
using ProiectColectiv.Models;

namespace ProiectColectiv.Repository
{
    public interface IJobsRepository : IRepository<Job>
    {
        IQueryable<Job> GetAvailableJobs();
    }
}