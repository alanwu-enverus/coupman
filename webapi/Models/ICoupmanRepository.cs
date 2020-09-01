using System.Linq;

namespace webapi.Models
{
    public interface ICoupmanRepository
    {
         IQueryable<User> Users {get;}
    }
}