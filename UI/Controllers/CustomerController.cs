using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Room;
using BLL.Room;
//using BLL.Customer;
using BLL;
using DAL;

namespace UI.Controllers
{
    public class CustomerController : Controller
    {
        CustomerRepositry Cust = new CustomerRepositry();
        // GET: Customer
        public ActionResult customer()
        {
            ViewBag.Customerid = TempData["customerid"];
            ViewBag.Roomid = TempData["Roomid"];
            TempData.Keep();
            if (ViewBag.Customerid ==null )
            {
                return RedirectToAction("Hotel", "Home");
            }
            else
            {
                return View();
            }
           
        }
        //GetData ****************

        //End Data****************
        //Get Customer By ID
        public JsonResult GetCustomer(int id)
        {
            IEnumerable<CustomerViewModel> Customer = Cust.GetCustomerByID(id);
            return Json(Customer.ToList(), JsonRequestBehavior.AllowGet);
        }
        RoomTypeRepositry Rooms = new RoomTypeRepositry();
        public JsonResult RoomType()
        {
            //Get Room Type
            IEnumerable<TypeRoomViewModel> TypeRoom = Rooms.GetAllType();
            return Json(TypeRoom.ToList(), JsonRequestBehavior.AllowGet);

        }
        //Get Room Number
        public JsonResult RoomNumber()
        {
            IEnumerable<RoomViewModel> Room = Rooms.NumberofRoom();
            return Json(Room.ToList(), JsonRequestBehavior.AllowGet);
        }
        //customer Register

        public ActionResult Register_Customer()
        {
            return View();
        }
        public JsonResult RegisterCustomer(CustomerViewModel Customer)
        {
            int A = Cust.Add(Customer);

            if (A == 0)
            {
               
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }

        }
        //CustomerRoom
        public ActionResult CustomerRome()
        {
            return View();
        }
        //TestEmail
        public JsonResult TestEmail(CustomerViewModel Email)
        {
            bool x = Cust.TestEmail(Email);
            if (x == true)
            {

                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }

        }
        //Login Customer
        public ActionResult LoginCustomer()
        {
            return View();
        }
        public JsonResult Login(CustomerViewModel login)
        {
            int x = Cust.Login(login);

            if (x != 0)
            {
                TempData["customerid"] = x;
                TempData.Keep();
                return Json(x, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }

        }
        //EndCustomer
        //RoomPage
       
        public JsonResult Room(int s,string search = "")
        {
            IEnumerable<RoomViewModel> Room = Rooms.GetAllRoom(s,search);
            return Json(Room.ToList(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetRoom(int id)
        {
            IEnumerable<RoomViewModel> Room = Rooms.GetByID(id);
            return Json(Room.ToList(), JsonRequestBehavior.AllowGet);
        }

        // Customer Room Page
        public ActionResult RoomCustomerRoom()
        {
            ViewBag.Customerid = TempData["customerid"];
            TempData.Keep();
           
            if (ViewBag.Customerid == null)
            {
                return RedirectToAction("Hotel", "Home");
            }
            else
            {
                return View();
            }
        }
        public ActionResult GEtRoomId(int id) {
            TempData["Roomid"] = id;
            TempData.Keep();
            return View();

        }
        ////////////////////
        //********CustomerRoom*******************
        RoomCustomerRepositry RC = new RoomCustomerRepositry();
        public JsonResult CustomerRoom(RoomCustomerViewModel RoomCustomer)
        {
            int A = RC.Add(RoomCustomer);
            TempData["Roomcustomerid"] = A;

            if (A != 0)
            {
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("success", JsonRequestBehavior.AllowGet);
            }

        }
        public ActionResult myRoom()
        {
            ViewBag.Customerid = TempData["customerid"];
            ViewBag.RoomCustomerid = TempData["Roomcustomerid"];
            TempData.Keep();
            if (ViewBag.Customerid == null)
            {
                return RedirectToAction("Hotel", "Home");
            }
            else
            {
                return View();
            }

        }
        RoomCustomerRepositry R = new RoomCustomerRepositry();
        public JsonResult Check(int id)
        {
            IEnumerable<RoomCustomerViewModel> Room = R.GtById(id);
            if (Room !=null)
            {
                return Json(Room.ToList(), JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }

              

        }
        public JsonResult Delet(int id)
        {
            bool A = R.Delete(id);
            if (A==true)
            {
                return Json("success", JsonRequestBehavior.AllowGet);

            }
            else
            {
                return Json("error", JsonRequestBehavior.AllowGet);

            }
        }
        //CheakRoom busy or not
        public JsonResult getCustomerRoom()
        {
            IEnumerable<RoomCustomerViewModel> Room = R.GetAll();
            return Json(Room.ToList(), JsonRequestBehavior.AllowGet);
        }
        //شكاوى
        ComplaitRepository Complait = new ComplaitRepository();
        public ActionResult Compoling()
        {
            ViewBag.Customerid = TempData["customerid"];
            TempData.Keep();
            if (ViewBag.Customerid == null)
            {
                return RedirectToAction("Hotel", "Home");
            }
            else
            {
                return View();
            }
        }
        public JsonResult sendCompling( ComplaitViewModel com,int id)
        {
          

            var A = Complait.Add(com,id);

            return Json("success", JsonRequestBehavior.AllowGet);
        }

    }
}