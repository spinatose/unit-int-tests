using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Fixtures
{
    public class MockDataService : IDataService
    {
        List<UserType> userTypes = new List<UserType>
        {
            new UserType { UserTypeId = 1, Name = "Admin" },
            new UserType { UserTypeId = 2, Name = "Client" }
        };  

        public IEnumerable<UserType> GetAllUserTypes()
        {
            return userTypes;
        }
    }
}
