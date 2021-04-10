using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using BLL;

namespace UI.Controllers
{
    public class LoginHotelsystemController : Controller
    {
        EmpoloyeeRepositry emp = new EmpoloyeeRepositry();
        // GET: LoginHotelsystem
        public ActionResult loginEmploye()
        {
            return View();
        }
        public JsonResult Login(EmpoloyeeViewModel empoloyee)
        {
            int Login = emp.Login(empoloyee);
            
            if (Login != 0)
            {
                TempData["Mangerid"] = Login;
                TempData.Keep();
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult SendIDToAdminControler()
        {
            var x = TempData["Mangerid"];
            TempData.Keep();
            return RedirectToAction("Getid", "Admin", new { id = x });

        }
        public ActionResult REGISTER()
        {
            return View();
        }
        public JsonResult AddEmpoloye(EmpoloyeeViewModel empoloyee)
        {
            bool x = emp.Add(empoloyee);
            if (x == true)
            {
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }

        }
        public JsonResult TestEmail(EmpoloyeeViewModel empoloyee)
        {
            bool x = emp.textRegister(empoloyee);
            if (x == true)
            {
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }

        }

        StaffRepositry ALLStaff = new StaffRepositry();
        public JsonResult Staff(StaffViewModel staff)
        {
            IEnumerable<StaffViewModel> Staff = ALLStaff.GetAll();
            return Json(Staff.ToList(), JsonRequestBehavior.AllowGet);
        }
        ShiftRepositry AllShift = new ShiftRepositry();
        public JsonResult Shift(ShiftViewModel shift)
        {
            IEnumerable<ShiftViewModel> Shift = AllShift.GetAll();
            return Json(Shift.ToList(), JsonRequestBehavior.AllowGet);
        }
        CardTaypeRepositry Card = new CardTaypeRepositry();
        public JsonResult AllCard(CardTypeViewModel card)
        {
            IEnumerable<CardTypeViewModel> Cardtype = Card.GetAll();
            return Json(Cardtype.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}