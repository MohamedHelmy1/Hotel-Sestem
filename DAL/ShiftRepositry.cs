using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DataModel;

namespace DAL
{
    interface IShiftRepositry
    {
        bool Add(ShiftViewModel shift);
        bool Uplood(ShiftViewModel shift);
        bool Delete(int id);
    }
    public class ShiftRepositry : IShiftRepositry
    {
        Hotel_SystemEntities context = new Hotel_SystemEntities();
        public bool Add(ShiftViewModel shift)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Uplood(ShiftViewModel shift)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<ShiftViewModel> GetAll()
        {
            List<ShiftViewModel> shift = new List<ShiftViewModel>();
            foreach (var item in context.ShiftTypes)
            {
                ShiftViewModel obj = new ShiftViewModel();
                obj.ShiftId = item.ShiftId;
                obj.ShiftType1 = item.ShiftType1;
                shift.Add(obj);
            }
            return shift;
        }
    }
}
