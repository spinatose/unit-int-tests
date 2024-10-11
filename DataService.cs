using Microsoft.EntityFrameworkCore;
using MyEFDataLibrary.Models;

namespace MyEFDataLibrary
{
    public class DataService : IDataService
    {
        private readonly DbContext context;

        public DataService(DbContext context)
        {
            this.context = context;
        }

        public IEnumerable<UserType> GetAllUserTypes() => context.Set<UserType>();

        public async Task<IEnumerable<UserType>> GetAllUserTypesAsync()
        {
            return await context.Set<UserType>().ToListAsync();
        }
    }
}
