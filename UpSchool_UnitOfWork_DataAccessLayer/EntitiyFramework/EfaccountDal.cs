using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool_UnitOfWork_DataAccessLayer.Abstract;
using UpSchool_UnitOfWork_DataAccessLayer.Concrete;
using UpSchool_UnitOfWork_DataAccessLayer.Repository;
using UpSchool_UnitOfWork_EntityLayer.Concrete;

namespace UpSchool_UnitOfWork_DataAccessLayer.EntitiyFramework
{
    public class EfaccountDal : GenericRepository<Account>, IAccountDal
    {
        public EfaccountDal(Context context) : base(context)
        {
        }
    }
}
