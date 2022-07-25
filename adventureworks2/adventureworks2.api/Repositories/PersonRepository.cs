using adventureworks2.api.Data;
using adventureworks2.api.Models.Domain;

namespace adventureworks2.api.Repositories
{
    public class PersonRepository : IPersonrepository
    {
        private readonly AdventurewalksDBContext adventurewalksDBContext;
        public PersonRepository(AdventurewalksDBContext adventurewalksDBContext)
        {
            this.adventurewalksDBContext = adventurewalksDBContext;
        }
        public IEnumerable<mPerson> GetAll()
        {
            return adventurewalksDBContext.Person.ToList();
        }
    }
}
