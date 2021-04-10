using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DataModel;

namespace DAL
{
    interface IComplaitRepository
    {
        bool Add(ComplaitViewModel complait,int id);
    }
   public class ComplaitRepository : IComplaitRepository
    {
        Hotel_SystemEntities db = new Hotel_SystemEntities();

        public bool Add(ComplaitViewModel complait ,int id)
        {
            var A = db.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
            
            Complait obj = new Complait();
            obj.CustomerName = A.Email;
            obj.TextComplait = complait.TextComplait;
            obj.TypeOfComplait = complait.TypeOfComplait;
            obj.time1 =DateTime.Now;
            db.Complaits.Add(obj);
            db.SaveChanges();
            return true;

            throw new NotImplementedException();
        }
        public IEnumerable<ComplaitViewModel> GetAllComplait(int val)
        {
            List<ComplaitViewModel> Complaits = new List<ComplaitViewModel>();
            var y = db.Complaits.Count();
            if (y==0)
            {

            }
            else
            {
                if (val == 1)
                {
                    foreach (var item in db.Complaits)
                    {

                        var z = DateTime.Now - item.time1;

                        var x = z.Value.Days;

                        if (x <= 1)
                        {
                            ComplaitViewModel obj = new ComplaitViewModel();
                            obj.CustomerName = item.CustomerName;
                            obj.TextComplait = item.TextComplait;
                            obj.TypeOfComplait = item.TypeOfComplait;
                            obj.id = item.id;
                            obj.time = item.time1.ToString();

                            Complaits.Add(obj);

                        }



                    }

                }
                if (val == 2)
                {
                    foreach (Complait item in db.Complaits)
                    {

                        var z = DateTime.Now - item.time1;
                        var x = z.Value.Days;

                        if (x <= 7)
                        {
                            ComplaitViewModel obj = new ComplaitViewModel();
                            obj.CustomerName = item.CustomerName;
                            obj.TextComplait = item.TextComplait;
                            obj.TypeOfComplait = item.TypeOfComplait;
                            obj.id = item.id;
                            obj.time = item.time1.ToString();

                            Complaits.Add(obj);

                        }



                    }

                }
                if (val == 3)
                {
                    foreach (Complait item in db.Complaits)
                    {

                        var z = DateTime.Now - item.time1;
                        var x = z.Value.Days;

                        if (x <= 30)
                        {
                            ComplaitViewModel obj = new ComplaitViewModel();
                            obj.CustomerName = item.CustomerName;
                            obj.TextComplait = item.TextComplait;
                            obj.TypeOfComplait = item.TypeOfComplait;
                            obj.id = item.id;
                            obj.time = item.time1.ToString();

                            Complaits.Add(obj);

                        }



                    }

                }
                if (val == 4)
                {
                    foreach (Complait item in db.Complaits)
                    {


                        ComplaitViewModel obj = new ComplaitViewModel();
                        obj.CustomerName = item.CustomerName;
                        obj.TextComplait = item.TextComplait;
                        obj.TypeOfComplait = item.TypeOfComplait;
                        obj.id = item.id;
                        obj.time = item.time1.ToString();

                        Complaits.Add(obj);




                    }

                }
                if (val == 5)
                {
                    foreach (Complait item in db.Complaits)
                    {

                        var z = DateTime.Now - item.time1;
                        var x = z.Value.Days;

                        if (x <= 2)
                        {
                            ComplaitViewModel obj = new ComplaitViewModel();
                            obj.CustomerName = item.CustomerName;
                            obj.TextComplait = item.TextComplait;
                            obj.TypeOfComplait = item.TypeOfComplait;
                            obj.id = item.id;
                            obj.time = item.time1.ToString();

                            Complaits.Add(obj);

                        }



                    }

                }
               

            }
            return Complaits.OrderByDescending(x => x.id);
        }
        public bool Delete(int id)
        {
            var a = db.Complaits.Where(x => x.id == id).FirstOrDefault();
            if (a!=null)
            {
                db.Complaits.Remove(a);
                db.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}
