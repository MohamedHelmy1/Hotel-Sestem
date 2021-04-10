using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DataModel;

namespace DAL
{
    interface IRoomCustomerRepositry
    {
        int Add(RoomCustomerViewModel RoomCustomer);
        bool Delete(int id);
        IEnumerable<RoomCustomerViewModel> GtById(int id);
    }
   public class RoomCustomerRepositry : IRoomCustomerRepositry
    {
        Hotel_SystemEntities db = new Hotel_SystemEntities();
        public int Add(RoomCustomerViewModel RoomCustomer)
        {
            var roomid = db.CustomerRooms.Where(x => x.RoomIdfk == RoomCustomer.RoomIdfk).FirstOrDefault();
            if (roomid != null)
            {
                return 0;
            }
            else
            {
                CustomerRoom obj = new CustomerRoom();
                obj.id = RoomCustomer.id;
                obj.CustomerIdfk = RoomCustomer.CustomerIdfk;
                obj.startDate = RoomCustomer.startDate;
                obj.EndData = RoomCustomer.EndData;
                obj.RoomIdfk = RoomCustomer.RoomIdfk;
                db.CustomerRooms.Add(obj);
                obj.IsPase = true;
               
                db.SaveChanges();
                return RoomCustomer.id;

            }
           
        }

        public bool Delete(int id)
        {
            var A = db.CustomerRooms.Where(x => x.id == id).FirstOrDefault();
            if (A != null)
            {
                db.CustomerRooms.Remove(A);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
          

           
        }

        public IEnumerable<RoomCustomerViewModel> GtById(int id)
        {
            List<RoomCustomerViewModel> RoomCustomer = new List<RoomCustomerViewModel>();
            foreach (var item in db.CustomerRooms.Where(x => x.CustomerIdfk == id))
            {
                RoomCustomerViewModel obj = new RoomCustomerViewModel();
                obj.id = item.id;
                obj.CustomerIdfk = item.CustomerIdfk;
                obj.Name = item.Customer.CustomerName;
                obj.startDate = item.startDate.ToString();
                obj.EndData = item.EndData.ToString() ;
                obj.RoomName = item.Room.RoomNo;
               
                RoomCustomer.Add(obj);
              


            }
            return RoomCustomer;
        }
        public IEnumerable<RoomCustomerViewModel> GetAll()
        {
            List<RoomCustomerViewModel> Room = new List<RoomCustomerViewModel>();
            foreach (var item in db.CustomerRooms)
            {
                RoomCustomerViewModel obj = new RoomCustomerViewModel();

                obj.id= item.id;
                obj.EndData = item.EndData;
                Room.Add(obj);

            }
            return Room;
        }
    }
}
