using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEFDataLibrary
{
    public class RepositoryService : IRepositoryService
    {
        private readonly IDataService dataService;

        public RepositoryService(IDataService dataService)
        {
            this.dataService = dataService;
        }

        public List<MyEFDataLibrary.Models.UserType> GetAllUserTypes()
        {
            return dataService.GetAllUserTypes().ToList();
        }

        public async Task<List<MyEFDataLibrary.Models.UserType>> GetAllUserTypesAsync()
        {
            return (await dataService.GetAllUserTypesAsync()).ToList();
        }
    }
}
