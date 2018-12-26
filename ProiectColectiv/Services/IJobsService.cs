using ProiectColectiv.ViewModels;

namespace ProiectColectiv.Services
{
    public interface IJobsService
    {
        JobsViewModel GetJobsViewModel(int page);
        DetailsJobViewModel GetDetailsJobViewModel(int id);
    }
}