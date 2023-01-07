using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSchool_UnitOfWork_EntityLayer.Concrete
{
    public class ProcessDetail
    {
        public int ProcessDetailId { get; set; }

        public string ReceiverName { get; set; }
        public string SenderName { get; set; }
        public decimal Amount { get; set; }
        public DateTime ProcessDate { get; set; }
    }
}
