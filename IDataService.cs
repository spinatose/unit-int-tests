using MyEFDataLibrary.Models;

namespace MyEFDataLibrary
{
    public interface IDataService
    {
        IEnumerable<UserType> GetAllUserTypes();

        Task<IEnumerable<UserType>> GetAllUserTypesAsync();
    }
}