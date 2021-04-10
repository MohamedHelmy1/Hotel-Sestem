using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BLL.Room
{
   public class RoomViewModel
    {

        public int RoomId { get; set; }
        public string RoomNo { get; set; }
        public Nullable<int> RoomType { get; set; }
        public Nullable<bool> Pass { get; set; }
        public Nullable<System.DateTime> checkIn { get; set; }
        public Nullable<System.DateTime> CheakOut { get; set; }
        public Nullable<double> prise { get; set; }
        public string RoomType1 { get; set; }
    }
}
