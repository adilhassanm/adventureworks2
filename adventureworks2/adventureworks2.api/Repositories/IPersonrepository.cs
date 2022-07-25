using adventureworks2.api.Models.Domain;

namespace adventureworks2.api.Repositories
{
    public interface IPersonrepository
    {
        IEnumerable<mPerson> GetAll();
    }
}
