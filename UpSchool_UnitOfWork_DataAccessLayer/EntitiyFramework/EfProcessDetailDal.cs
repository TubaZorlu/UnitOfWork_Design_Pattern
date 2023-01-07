
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
    public class EfProcessDetailDal : GenericRepository<ProcessDetail>, IProcessDetailDal
    {
        public EfProcessDetailDal(Context context) : base(context)
        {
        }
    }
}
