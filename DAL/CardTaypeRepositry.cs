using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using BLL;

namespace DAL
{
    interface ICardTaypeRepositry
    {
        bool Add(CardTypeViewModel CardType);
        bool uplood(CardTypeViewModel CardType);
        bool Delete(int id);

    }

    public class CardTaypeRepositry : ICardTaypeRepositry
    {
        Hotel_SystemEntities db = new Hotel_SystemEntities();
        public bool Add(CardTypeViewModel CardType)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool uplood(CardTypeViewModel CardType)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<CardTypeViewModel> GetAll()
        {
            List<CardTypeViewModel> CardType = new List<CardTypeViewModel>();
            foreach (var item in db.CardTypes)
            {
                CardTypeViewModel obj = new CardTypeViewModel();
                obj.IdCardType = item.IdCardType;
                obj.IdCardTypeId = item.IdCardTypeId;
                CardType.Add(obj);

            }
            return CardType;
        }
    }
}
