using batdongsan.Model;
using batdongsan.Model.Table;
using Service.Base;

namespace batdongsan.Service.AllService
{
    public interface IUserService : IBaseService<User>
    {
        
    }
    public class UserService : BaseService<User>,IUserService
    {
        public UserService(ApplicationDbContext dbContext): base(dbContext)
        {
            
        }
    }
}