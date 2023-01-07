using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool_UnitOfWork_BusinessLayer.Abstract;
using UpSchool_UnitOfWork_DataAccessLayer.Abstract;
using UpSchool_UnitOfWork_DataAccessLayer.UnitOfWork;
using UpSchool_UnitOfWork_EntityLayer.Concrete;

namespace UpSchool_UnitOfWork_BusinessLayer.Concrete
{
    public class ProcessDetailManager : IProcessDetailService
    {
        private readonly IProcessDetailDal _processDetailDal;
        private readonly IUowDal _uowDal;

        public ProcessDetailManager(IProcessDetailDal processDetailDal, IUowDal uowDal)
        {
            _processDetailDal = processDetailDal;
            _uowDal = uowDal;
        }

        public void TDelete(ProcessDetail t)
        {
            _processDetailDal.Delete(t);
            _uowDal.save();
        }

        public ProcessDetail TGetById(int id)
        {
            return _processDetailDal.GetById(id);
            
        }

        public List<ProcessDetail> TGetList()
        {
            return _processDetailDal.GetList();
        }

        public void TInsert(ProcessDetail t)
        {
            _processDetailDal.Insert(t);
            _uowDal.save();
        }

        public void TMultiUpdate(List<ProcessDetail> t)
        {
            _processDetailDal.MultiUpdate(t);
            _uowDal.save();
        }

        public void TUpdate(ProcessDetail t)
        {
            _processDetailDal.Update(t);
            _uowDal.save();
        }
    }
}
