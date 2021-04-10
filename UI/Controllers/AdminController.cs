using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using BLL;
using BLL.Room;
using DAL.Room;
using DataModel;
//using BLL.Customer;

namespace UI.Controllers
{
    public class AdminController : Controller
    {
        //Home

        ///**********************
         public ActionResult Getid(int id)
        {
            TempData["Mangerid"] = id;
            TempData.Keep();
            return RedirectToAction("index");
        }
        // GET: Admin
        public ActionResult Index()
        {
            var x = TempData["Mangerid"];
            TempData.Keep();
            if (x == null)
            {
                return RedirectToAction("Hotel", "Home");
            }
            else
            {
                return View();
            }
            
        }
        AdminRepository Admin = new AdminRepository();
        public JsonResult ComplaitsNumber()
        {
            var A = Admin.GetComplaitsNumber();
            return Json(A,JsonRequestBehavior.AllowGet);
        }
        public JsonResult CustomerNumber()
        {

            var A = Admin.GetCustomerNumber();
            return Json(A, JsonRequestBehavior.AllowGet);
        }
        public JsonResult AvailableRoom()
        {
            var A = Admin.GetAvailableRoomNumber();
            return Json(A, JsonRequestBehavior.AllowGet);
        }
        public JsonResult AllRoomNumber()
        {

            var A = Admin.GetRoomNumber();
            return Json(A, JsonRequestBehavior.AllowGet);
        }
        public JsonResult AllEmpoiyeeNumber()
        {

            var A = Admin.GetEmpoloyeeNumber();
            return Json(A, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetEmpoloyee()
        {
            var x = TempData["Mangerid"];
            TempData.Keep();
            if (x == null)
            {
                return RedirectToAction("Hotel", "Home");
            }
            else
            {
                return View();
            }

        }
        EmpoloyeeRepositry Amp = new EmpoloyeeRepositry();
        public JsonResult Emp()
        {

            IEnumerable<EmpoloyeeViewModel> Empoloyee = Admin.GetAllEmpoloyee();
           
                return Json(Empoloyee.ToList(), JsonRequestBehavior.AllowGet);
            
        }
        public JsonResult updateEmpoloyee(int id)
        {

            IEnumerable<EmpoloyeeViewModel> Empoloyee = Amp.updateEmpoloyee(id);

            return Json(Empoloyee.ToList(), JsonRequestBehavior.AllowGet);

        }
        public JsonResult updateEmpoloyees(EmpoloyeeViewModel empoloyee)
        {

            bool a = Amp.Update(empoloyee);
            if (a == true) 
            {
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
	        {
                return Json("eror", JsonRequestBehavior.AllowGet);
            }
            
            

        }

        public JsonResult DeletEmpoloyee(int id)
        {

            bool A = Amp.Delete(id);


            return Json("Success", JsonRequestBehavior.AllowGet);

        }
        public ActionResult GetCustomer()
        {
            var x = TempData["Mangerid"];
            TempData.Keep();
            if (x == null)
            {
                return RedirectToAction("Hotel", "Home");
            }
            else
            {
                return View();
            }

        }
        public JsonResult customer(string search)
        {

            IEnumerable<CustomerViewModel> customer = Admin.GetAllCustomer(search);
            return Json(customer.ToList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Room()
        {
            var x = TempData["Mangerid"];
            TempData.Keep();
            if (x == null)
            {
                return RedirectToAction("Hotel", "Home");
            }
            else
            {
                return View();
            }

        }
        RoomTypeRepositry R = new RoomTypeRepositry();

        public JsonResult updataRoom(RoomViewModel Room)
        {
            bool a = R.Uplood(Room);
            if (a==true)
            {
                return Json("A", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
        Hotel_SystemEntities db = new Hotel_SystemEntities();
        public JsonResult AddRoom(Room Room)
        {
            db.Rooms.Add(Room);
            db.SaveChanges();
            return Json("Succes", JsonRequestBehavior.AllowGet);

        }
        //*********************
        //search

        public JsonResult Search(int s, string search )
        {

            IEnumerable<EmpoloyeeViewModel> Empoloyee = Amp.search(s,search);

            return Json(Empoloyee.ToList(), JsonRequestBehavior.AllowGet);

        }
        ComplaitRepository com = new ComplaitRepository();
        public ActionResult Compoling()
        {

            var x = TempData["Mangerid"];
            TempData.Keep();
            if (x == null)
            {
                return RedirectToAction("Hotel", "Home");
            }
            else
            {
                return View();
            }
        }
        public JsonResult Compolings(int id)
        {
            IEnumerable<ComplaitViewModel> Compoling = com.GetAllComplait(id);
            return Json(Compoling.ToList(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult DeletCompolts(int id)
        {
            bool a = com.Delete(id);
            if (a==true)
            {
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
        //vister
        public JsonResult vister()
        {
            bool x = Admin.Vister();
            return Json("", JsonRequestBehavior.AllowGet);
        }
        public JsonResult vistercount()
        {
            var x =Admin.visterCount();
            return Json(x, JsonRequestBehavior.AllowGet);
        }

    }
}