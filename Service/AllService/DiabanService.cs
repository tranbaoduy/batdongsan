using batdongsan.Model.Table;
using Service.Base;
using batdongsan.Model;

namespace batdongsan.Service.AllService
{
    public interface IDiabanService : IBaseService<Diaban>
    {
        
    }
    public class DiabanService : BaseService<Diaban>,IDiabanService
    {
        public DiabanService(ApplicationDbContext dbContext): base(dbContext)
        {

        }
    }
}