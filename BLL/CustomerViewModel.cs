using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BLL/*.Customer*/
{
  public  class CustomerViewModel
    {

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string IdCardNumber { get; set; }
        public Nullable<int> IdCardTypeFK { get; set; }
        public string Address { get; set; }
        public string RemaininigAmount { get; set; }
        public Nullable<int> phoneNumber { get; set; }
        public string password { get; set; }
        public string gender { get; set; }

        
    }
}
