using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool_UnitOfWork_DataAccessLayer.Concrete;

namespace UpSchool_UnitOfWork_DataAccessLayer.UnitOfWork
{
    public class UowDal:IUowDal
    {
        private readonly Context _context;

        public UowDal(Context context)
        {
            _context = context;
        }

        public void save()
        {
            _context.SaveChanges();
        }
    }
}
