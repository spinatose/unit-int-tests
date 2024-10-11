using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Fixtures;

namespace TestProject.UnitTests
{
    [TestClass]
    public class RepositoryServiceTests
    {
        [TestMethod]
        public void GetUserTypes_ReturnsTwo()
        {
            // Arrange
            IDataService dataService = new MockDataService();
            IRepositoryService repoService = new RepositoryService(dataService);

            // Act
            List<UserType> userTypes = repoService.GetAllUserTypes();

            // Assert
            Assert.AreEqual(2, userTypes.Count);
        }
    }
}
