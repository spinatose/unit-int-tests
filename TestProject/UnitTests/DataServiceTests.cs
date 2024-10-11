using Microsoft.EntityFrameworkCore;
using Moq;

namespace TestProject.UnitTests
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void GetUserTypes_ReturnsTwo()
        {
            var mockSet = new Mock<DbSet<UserType>>();
            var mockContext = new Mock<DbContext>();

            var data = new List<UserType>
            {
                new UserType { UserTypeId = 1, Name = "Admin" },
                new UserType { UserTypeId = 2, Name = "Client" }
            }.AsQueryable();

            mockSet.As<IQueryable<UserType>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<UserType>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<UserType>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<UserType>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            mockContext.Setup(c => c.Set<UserType>()).Returns(mockSet.Object);

            var service = new DataService(mockContext.Object);

            // Act
            var result = service.GetAllUserTypes().ToList();

            // Assert
            Assert.AreEqual(2, result.Count());
        }

        /// <summary>
        /// Expected to FAIL due to complexity of mocking EF async - which shouldn't be what we
        /// need to test anyway. 
        /// </summary>
        /// <returns></returns>

        [TestMethod]
        public async Task GetUserTypesAsync_ReturnsTwo()
        {
            var mockSet = new Mock<DbSet<UserType>>();
            var mockContext = new Mock<DbContext>();

            var data = new List<UserType>
            {
                new UserType { UserTypeId = 1, Name = "Admin" },
                new UserType { UserTypeId = 2, Name = "Client" }
            }.AsQueryable();

            mockSet.As<IQueryable<UserType>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<UserType>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<UserType>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<UserType>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            mockContext.Setup(c => c.Set<UserType>()).Returns(mockSet.Object);

            var service = new DataService(mockContext.Object);

            // Act
            var result = await service.GetAllUserTypesAsync();

            // Assert
            Assert.AreEqual(2, result.ToList().Count());
        }
    }
}