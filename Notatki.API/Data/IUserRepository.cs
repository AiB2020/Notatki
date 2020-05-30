using System.Collections.Generic;
using System.Threading.Tasks;
using Notatki.API.Models;

namespace Notatki.API.Data
{
    public interface IUserRepository : IGenericRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
        Task<Photo> GetPhoto(int id);
    }
} 