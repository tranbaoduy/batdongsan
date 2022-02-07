using batdongsan.Model;
using batdongsan.Service.AllService;

namespace batdongsan.Service.AllService
{
   public interface IRepositoryService
   {
      IDiabanService Diaban {get;}
      IUserService User {get;}
      void save();
   }

   public class RepositoryService : IRepositoryService
   {
      private ApplicationDbContext _context;
      private IUserService _User;
      private IDiabanService _Diaban;

      public RepositoryService(ApplicationDbContext context) {
         _context = context;
      }

      public IUserService User
      {
         get 
         {
            if(_User == null)
            {
               _User = new UserService(_context);
            }
            return _User;
         }
      }

      public IDiabanService Diaban
      {
         get 
         {
            if(_Diaban == null)
            {
               _Diaban = new DiabanService(_context);
            }
            return _Diaban;
         }
      }

      public void save(){
         _context.SaveChanges();
      }
   }
}