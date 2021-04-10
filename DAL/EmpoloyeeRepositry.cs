using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DataModel;


namespace DAL
{
    interface IEmpoloyeeRepositry
    {
        bool Add(EmpoloyeeViewModel empoloyee);
        bool Update(EmpoloyeeViewModel empoloyee);
        bool Delete(int id);
        EmpoloyeeViewModel GetByID(int id);
        int Login(EmpoloyeeViewModel login);
        bool textRegister(EmpoloyeeViewModel empoloyee);



    }
   public class EmpoloyeeRepositry : IEmpoloyeeRepositry
    {
        Hotel_SystemEntities context = new Hotel_SystemEntities(); 
        public bool Add(EmpoloyeeViewModel empoloyee)
        {
            var email = context.Employes.Where(x => x.Email == empoloyee.Email).FirstOrDefault();
            
            try
            {
                if (email==null)
                {
                    Employe obj = new Employe();
                    obj.EmployeeId = empoloyee.EmployeeId;
                    obj.EmployeeName = empoloyee.EmployeeName;
                    obj.EmployementTypeFk = empoloyee.EmployementTypeFk;
                    obj.PhoneNumber = empoloyee.PhoneNumber;
                    obj.Shift = empoloyee.Shift;
                    obj.IdCardTypeFk = empoloyee.IdCardTypeFk;
                    obj.IdCardNumber = empoloyee.IdCardNumber;
                    obj.JoiningData = empoloyee.JoiningData1;
                    obj.Salary = empoloyee.Salary;
                    obj.Email = empoloyee.Email;
                    obj.Gender = empoloyee.Gender;
                    obj.password = empoloyee.password;
                    context.Employes.Add(obj);
                    context.SaveChanges();
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
           
            

           
        }

        public bool Delete(int id)
        {
            var A = context.Employes.Where(x => x.EmployeeId == id).FirstOrDefault();
            context.Employes.Remove(A);
            context.SaveChanges();
            return true;
        }

        public EmpoloyeeViewModel GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int Login(EmpoloyeeViewModel login)
        {
            var Empoloyee = context.Employes.Where(x => (x.Email == login.Email || x.PhoneNumber == login.PhoneNumber || x.EmployeeName == login.EmployeeName) && x.password == login.password).FirstOrDefault();
            if (Empoloyee!=null)
            {
                
                var log = context.Employes.Where(x => (x.Email == login.Email || x.PhoneNumber == login.PhoneNumber || x.EmployeeName == login.EmployeeName) && x.password == login.password).Select(x => x.EmployeeId).FirstOrDefault();
                return log;
            }
            else
            {
                return 0;
            }
        }

        public bool textRegister(EmpoloyeeViewModel empoloyee)
        {
            var test = context.Employes.Where(x => x.Email == empoloyee.Email).FirstOrDefault();

            try
            {
                if (test.Email == empoloyee.Email)
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

       

        public bool Update(EmpoloyeeViewModel empoloyee)
        {
            var Em = context.Employes.Where(x => x.EmployeeId == empoloyee.EmployeeId).FirstOrDefault();
            if (Em!=null)
            {
                Em.EmployeeId = empoloyee.EmployeeId;
                Em.EmployeeName = empoloyee.EmployeeName;
                Em.EmployementTypeFk = empoloyee.EmployementTypeFk;
                Em.PhoneNumber = empoloyee.PhoneNumber;
                Em.Shift = empoloyee.Shift;
                Em.IdCardTypeFk = empoloyee.IdCardTypeFk;
                Em.IdCardNumber = empoloyee.IdCardNumber;
                //Em.JoiningData = Em.JoiningData;
                Em.Salary = empoloyee.Salary;
                Em.Email = empoloyee.Email;
                Em.Gender = empoloyee.Gender;
                Em.password = empoloyee.password;
                context.SaveChanges();
                return true;


            }
            else
            {
                return false;
            }

        }
        public IEnumerable<EmpoloyeeViewModel> updateEmpoloyee(int id)
        {

            List<EmpoloyeeViewModel> Empoloyee = new List<EmpoloyeeViewModel>();

            foreach (var item in context.Employes.Where(x => x.EmployeeId == id))
            {


                EmpoloyeeViewModel obj = new EmpoloyeeViewModel();
                obj.EmployeeId = item.EmployeeId;

                obj.Email = item.Email;
                obj.EmployeeName = item.EmployeeName;

                obj.EmployementTypeFk = item.EmployementTypeFk;
                obj.Gender = item.Gender;
                obj.IdCardNumber = item.IdCardNumber;

                obj.IdCardTypeFk = item.IdCardTypeFk;
                obj.JoiningData = item.JoiningData.ToString();
                obj.PhoneNumber = item.PhoneNumber;
                obj.Salary = item.Salary;
                obj.Shift = item.Shift;
                obj.password = item.password;



                Empoloyee.Add(obj);
            }
            return Empoloyee;
        }
        public IEnumerable<EmpoloyeeViewModel> search(int s,string search)
        {
            List<EmpoloyeeViewModel> Empoloyee = new List<EmpoloyeeViewModel>();

            if (s==1)
            {
                foreach (var item in context.Employes.Where(x=>x.EmployeeName.Contains(search)))
                {


                    EmpoloyeeViewModel obj = new EmpoloyeeViewModel();
                    obj.EmployeeId = item.EmployeeId;

                    obj.Email = item.Email;
                    obj.EmployeeName = item.EmployeeName;

                    obj.EmployementTypeFk1 = item.EmployementType.EmployementType1;
                    obj.Gender = item.Gender;
                    obj.IdCardNumber = item.IdCardNumber;

                    obj.IdCardTypeFk1 = item.CardType.IdCardType;
                    obj.JoiningData = item.JoiningData.ToString();
                    obj.PhoneNumber = item.PhoneNumber;
                    obj.Salary = item.Salary;
                    obj.Shift12 = item.ShiftType.ShiftType1;
                    obj.password = item.password;



                    Empoloyee.Add(obj);
                }
            }
            else if (s==2)
            {
                foreach (var item in context.Employes.Where(x => x.Email.Contains(search)))
                {


                    EmpoloyeeViewModel obj = new EmpoloyeeViewModel();
                    obj.EmployeeId = item.EmployeeId;

                    obj.Email = item.Email;
                    obj.EmployeeName = item.EmployeeName;

                    obj.EmployementTypeFk1 = item.EmployementType.EmployementType1;
                    obj.Gender = item.Gender;
                    obj.IdCardNumber = item.IdCardNumber;

                    obj.IdCardTypeFk1 = item.CardType.IdCardType;
                    obj.JoiningData = item.JoiningData.ToString();
                    obj.PhoneNumber = item.PhoneNumber;
                    obj.Salary = item.Salary;
                    obj.Shift12 = item.ShiftType.ShiftType1;
                    obj.password = item.password;

                    Empoloyee.Add(obj);
                }

            }
            else if (s == 3)
            {
                foreach (var item in context.Employes.Where(x => x.EmployementType.EmployementType1.Contains(search)))
                {


                    EmpoloyeeViewModel obj = new EmpoloyeeViewModel();
                    obj.EmployeeId = item.EmployeeId;

                    obj.Email = item.Email;
                    obj.EmployeeName = item.EmployeeName;

                    obj.EmployementTypeFk1 = item.EmployementType.EmployementType1;
                    obj.Gender = item.Gender;
                    obj.IdCardNumber = item.IdCardNumber;

                    obj.IdCardTypeFk1 = item.CardType.IdCardType;
                    obj.JoiningData = item.JoiningData.ToString();
                    obj.PhoneNumber = item.PhoneNumber;
                    obj.Salary = item.Salary;
                    obj.Shift12 = item.ShiftType.ShiftType1;
                    obj.password = item.password;
                    Empoloyee.Add(obj);
                }

            }

            return Empoloyee;
        }
    }
}
