using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DataModel;

namespace DAL
{
    interface IStaffRepositry
    {
        bool Add(StaffViewModel staff);
        bool Update(StaffViewModel staff);
        bool Delete(int id);
    }
  public  class StaffRepositry : IStaffRepositry
    {
        Hotel_SystemEntities context = new Hotel_SystemEntities();
        public bool Add(StaffViewModel staff)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(StaffViewModel staff)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<StaffViewModel> GetAll()
        {
            List<StaffViewModel> staff = new List<StaffViewModel>();
            foreach (var item in context.EmployementTypes)
            {
                StaffViewModel obj = new StaffViewModel();
                obj.EmployementId = item.EmployementId;
                obj.EmployementType1 = item.EmployementType1;
                staff.Add(obj);


            }
            return staff;
                

        }
    }
}
