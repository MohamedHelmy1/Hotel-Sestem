using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   
  public  class RoomCustomerViewModel
    {
        public int id { get; set; }
        public Nullable<int> CustomerIdfk { get; set; }
        public Nullable<int> RoomIdfk { get; set; }
        public Nullable<System.DateTime> DataStart { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public string Name { get; set; }
        public string RoomName { get; set; }

        public string startDate { get; set; }
        public string EndData { get; set; }
    }
}
