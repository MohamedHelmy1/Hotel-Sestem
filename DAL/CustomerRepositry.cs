using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using BLL.Customer;
using DataModel;
using BLL;

namespace DAL
{
    interface ICustomerRepositry
    {
        int Add(CustomerViewModel customer);
        bool TestEmail(CustomerViewModel customer);
        int Login(CustomerViewModel login);
           

    }
    public class CustomerRepositry : ICustomerRepositry
    {
        Hotel_SystemEntities db = new Hotel_SystemEntities();
        public int Add(CustomerViewModel customer)
        {
            var emaill = db.Customers.Where(x => x.Email == customer.Email).FirstOrDefault();
            if (emaill == null)
            {
                Customer obj = new Customer();
                obj.CustomerId = customer.CustomerId;
                obj.Address = customer.Address;
                obj.CustomerName = customer.CustomerName;
                obj.Email = customer.Email;
                obj.gender = customer.gender;
                obj.password = customer.password;
                obj.phoneNumber = customer.phoneNumber;
                obj.RemaininigAmount = customer.RemaininigAmount;
                obj.IdCardNumber = customer.IdCardNumber;
                obj.IdCardTypeFK = customer.IdCardTypeFK;
                db.Customers.Add(obj);
                db.SaveChanges();
                return customer.CustomerId;


            }
            else
            {
                return 0;
            }


        }

        public int Login(CustomerViewModel login)
        { 
            var Login = db.Customers.Where(x => (x.Email == login.Email || x.phoneNumber == login.phoneNumber) && x.password == login.password).Select(x => x.CustomerId).FirstOrDefault();

            if (Login != 0)
            {
                return Login;
            }
            else
            {
                return 0;
            }
        }

        public bool TestEmail(CustomerViewModel customer)
        {

            var test = db.Customers.Where(x => x.Email == customer.Email).Select(x=>x.Email);

            try
            {
                if (test==null)
                {

                    return true;
                }
                else { return false; }
            }
            catch (Exception)
            {

                return false;
            }
        }
        public IEnumerable<CustomerViewModel> GetCustomerByID(int id)
        {
            List<CustomerViewModel> Customer = new List<CustomerViewModel>();
            foreach (var item in db.Customers.Where(x=>x.CustomerId==id))
            {
                CustomerViewModel obj = new CustomerViewModel();
                obj.CustomerName = item.CustomerName;
                obj.Email = item.Email;
                obj.Address = item.Address;
                obj.IdCardNumber = item.IdCardNumber;
                obj.IdCardTypeFK = item.IdCardTypeFK;
                obj.phoneNumber = item.phoneNumber;

                Customer.Add(obj);

            }
            return Customer;


        }

    }
}
