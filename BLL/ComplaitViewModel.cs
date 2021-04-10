using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ComplaitViewModel
    {
        public string time;

        public string CustomerName { get; set; }
        public string TypeOfComplait { get; set; }
        public string TextComplait { get; set; }
        public int id { get; set; }
        public int? vister { get; set; }
        public DateTime? time1 { get; set; }
    }
}
