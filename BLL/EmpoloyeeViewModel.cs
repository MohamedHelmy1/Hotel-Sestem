using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BLL
{
     public class EmpoloyeeViewModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public Nullable<int> Shift { get; set; }
        public string JoiningData { get; set; }
        public Nullable<System.DateTime> JoiningData1 { get; set; }
        public Nullable<double> Salary { get; set; }
        public string IdCardNumber { get; set; }
        public Nullable<int> IdCardTypeFk { get; set; }
        public Nullable<int> PhoneNumber { get; set; }
        public Nullable<int> EmployementTypeFk { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string password { get; set; }


        public virtual CardType CardType { get; set; }
        public virtual EmployementType EmployementType { get; set; }
        public virtual ShiftType ShiftType { get; set; }
        public string EmployementTypeFk1 { get; set; }
        
        public string Shift12 { get; set; }
        public string IdCardTypeFk1 { get; set; }
    }
}
