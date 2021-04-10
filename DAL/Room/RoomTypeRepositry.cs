using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using BLL.Room;

namespace DAL.Room
{
    interface IRoomTypeRepositry
    {
        bool Add(RoomViewModel oom);
        bool Uplood(RoomViewModel Room);
        bool Delete(int id);
        IEnumerable<RoomViewModel> GetByID(int id);



    }
    public class RoomTypeRepositry : IRoomTypeRepositry
    {
        Hotel_SystemEntities db = new Hotel_SystemEntities();
      
        public bool Add(RoomViewModel oom)
        {
            
            
           
            
            


            throw new NotImplementedException();
        }
        
        public bool Delete(int id)
        {
           

            throw new NotImplementedException();
        }

        public bool Uplood(RoomViewModel Room)
        {
            var R = db.Rooms.Where(x => x.RoomId == Room.RoomId).FirstOrDefault();
            R.RoomNo = Room.RoomNo;
           
            R.RoomType = Room.RoomType;
            R.Pass = Room.Pass;
            R.prise = Room.prise;
            db.SaveChanges();
            return true;
        }
        //Get All Room
        public IEnumerable<RoomViewModel> GetAllRoom(int s ,string searh)
        {
            List<RoomViewModel> Room = new List<RoomViewModel>();
            foreach (var item in db.Rooms.Where(x=>x.RoomNo.Contains(searh)))
            {
                var a = db.CustomerRooms.Where(x => x.RoomIdfk == item.RoomId).FirstOrDefault();

                if (s == 1)
                {
                    if (a != null)
                    {

                    }
                    else
                    {
                        RoomViewModel obj = new RoomViewModel();
                        obj.RoomId = item.RoomId;
                        obj.RoomNo = item.RoomNo;
                        obj.RoomType = item.RoomType;
                       
                        obj.Pass = true;
                        obj.prise = item.prise;
                        Room.Add(obj);
                    }
                }

                else
                {

                    RoomViewModel obj = new RoomViewModel();
                    obj.RoomId = item.RoomId;
                    obj.RoomNo = item.RoomNo;
                    obj.RoomType1 = item.RoomType1.Type;

                    obj.Pass = true;
                    obj.prise = item.prise;
                    Room.Add(obj);

                }



            }
            return Room;
        }
        //Get All Rooo Type
        public IEnumerable<TypeRoomViewModel> GetAllType()
        {
            List<TypeRoomViewModel> TypeRoom = new List<TypeRoomViewModel>();

            foreach (var item in db.RoomTypes)
            {
                TypeRoomViewModel obj = new TypeRoomViewModel();
                obj.RoomType1 = item.RoomType1;
                obj.Type = item.Type;
                TypeRoom.Add(obj);

            }
            return TypeRoom;

        }
        //get Room Nimber
        public IEnumerable<RoomViewModel> NumberofRoom()
        {
            //var i = db.RoomTypes.Where(x => x.Type == RoomType).Select(x => x.RoomType1).FirstOrDefault(); 
            List<RoomViewModel> RoomNumber = new List<RoomViewModel>();

            foreach (var item in db.Rooms/*.Where(x => x.RoomType == RoomType)*/)
            {
                RoomViewModel obj = new RoomViewModel();
                obj.RoomId = item.RoomId;
                obj.RoomNo = item.RoomNo;
                RoomNumber.Add(obj);

            }
            return RoomNumber;




        }

        public IEnumerable<RoomViewModel> GetByID(int id)
        {
            List<RoomViewModel> Room = new List<RoomViewModel>();
            foreach (var item in db.Rooms.Where(x=>x.RoomId==id))
            {
               
                    RoomViewModel obj = new RoomViewModel();
                obj.RoomId = item.RoomId;
                    obj.RoomNo = item.RoomNo;
                    obj.RoomType = item.RoomType;
                    obj.prise = item.prise;
                    Room.Add(obj);
                


                //    try
                //    {
                //        if (a != null)
                //        {
                //            RoomViewModel obj = new RoomViewModel();
                //            obj.RoomNo = item.RoomNo;
                //            obj.RoomType = item.RoomType;
                //            obj.prise = item.prise;
                //            Room.Add(obj);
                //        }


                //    }

                //    catch (Exception)
                //    {


                //    }


                //}

                //var  Room = from obj in db.Rooms
                //        where obj.RoomId == id
                //        select new
                //        {
                //            obj.RoomNo,
                //            obj.RoomType,
                //            obj.prise


                //        };




            }
            return Room;
        }
    }
} 

