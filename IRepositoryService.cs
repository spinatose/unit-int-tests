using MyEFDataLibrary.Models;

namespace MyEFDataLibrary
{
    public interface IRepositoryService
    {
        List<UserType> GetAllUserTypes();

        Task<List<UserType>> GetAllUserTypesAsync();
    }
}