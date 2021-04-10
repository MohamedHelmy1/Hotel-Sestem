using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DataModel;
//using BLL.Customer;


namespace DAL
{
    interface IAdminRepository
    {
        int GetCustomerNumber();

    }
   public  class AdminRepository: IAdminRepository
    {
        Hotel_SystemEntities db = new Hotel_SystemEntities();
        public IEnumerable<CustomerViewModel> GetAllCustomer(string search)
        {
         
            List<CustomerViewModel> Customer = new List<CustomerViewModel>();
            foreach (var item in db.Customers.Where(x=>x.CustomerName.Contains(search)))
            {

                CustomerViewModel obj = new CustomerViewModel();
                obj.CustomerName = item.CustomerName;

                obj.Address = item.Address;
               
                obj.Email = item.Email;
                obj.gender = item.gender;

                obj.phoneNumber = item.phoneNumber;
                obj.RemaininigAmount = item.RemaininigAmount;
                obj.IdCardNumber = item.IdCardNumber;
                obj.IdCardTypeFK = item.IdCardTypeFK;

                Customer.Add(obj);
            }
            return Customer;
        }
        public IEnumerable<EmpoloyeeViewModel> GetAllEmpoloyee()
        {

            List<EmpoloyeeViewModel> Empoloyee = new List<EmpoloyeeViewModel>();
            
            foreach (var item in db.Employes.Where(x=>x.EmployeeId!=57))
            {


                EmpoloyeeViewModel obj = new EmpoloyeeViewModel();
                obj.EmployeeId = item.EmployeeId;
               
                obj.Email = item.Email;
                obj.EmployeeName = item.EmployeeName;

                obj.EmployementTypeFk1 = item.EmployementType.EmployementType1;
                obj.Gender = item.Gender;
                obj.IdCardNumber = item.IdCardNumber;

                obj.IdCardTypeFk1 = item.CardType.IdCardType;
                obj.JoiningData= item.JoiningData.ToString();
                obj.PhoneNumber = item.PhoneNumber;
                obj.Salary = item.Salary;
                obj.Shift12 = item.ShiftType.ShiftType1;
                obj.password = item.password;



                Empoloyee.Add(obj);
            }
            return Empoloyee;
        }

        public int GetCustomerNumber()
        {
           
            var A = db.Customers.Count();
           
            return A ;
        }
        public int GetComplaitsNumber()
        {
           
            var A = db.Complaits.Count();
            return A;
        }
        public int GetRoomNumber()
        {

            var A = db.Rooms.Count();
            return A;
        }
        public int GetEmpoloyeeNumber()
        {

            var A = db.Employes.Count();
            return A;
        }
        public int GetAvailableRoomNumber()
        {
            var z = db.Rooms.Count();
            var c = db.CustomerRooms.Count();
            var A = z - c;
            return A;
        }
        //vister
        public bool Vister()
        {
            var A = db.visters.Where(x => x.id == 1).FirstOrDefault();
            A.vister1 = A.vister1 + 1;
            db.SaveChanges();
            return true;
            
        }
        public int? visterCount()
        {
            var A = db.visters.Where(x => x.id == 1).FirstOrDefault();
            return A.vister1;
        }


    }
}
  

//********************************************************

