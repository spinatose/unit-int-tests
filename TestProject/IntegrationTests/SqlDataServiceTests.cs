using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.IntegrationTests
{
    [TestClass]
    public class SqlDataServiceTests
    {
        [TestMethod]
        public void GetUserTypes_HasAdmin()
        {
            // Arrange
            ClientPortalContext context = new ClientPortalContext();
            IDataService dataService = new DataService(context);
            IRepositoryService repoService = new RepositoryService(dataService);

            // Act
            List<UserType> userTypes = repoService.GetAllUserTypes();

            // Assert
            Assert.IsNotNull(userTypes.FirstOrDefault(o => o.Name == "Admin"));
        }
    }
}
