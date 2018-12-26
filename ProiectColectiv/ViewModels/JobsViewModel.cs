using ProiectColectiv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectColectiv.ViewModels
{
    public class JobsViewModel
    {
        public List<Job> Jobs { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }
    }
}
