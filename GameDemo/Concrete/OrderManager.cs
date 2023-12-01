using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class OrderManager : IOrderService
    {
        public void SellGame(Gamer gamer, Game game)
        {

            
            if (game.Campaign!=null) 
            {
                decimal discountAmount = (game.UnitPrice * game.Campaign.DiscountRate) / 100;
                game.UnitPrice -= discountAmount;

                Console.WriteLine(gamer.FirstName + " adlı kullanıcı " + game.Name + " adlı oyunu " + game.UnitPrice + " TL Fiyat ile satın aldı");
            }
            else
            {
                Console.WriteLine(gamer.FirstName + " adlı kullanıcı " + game.Name + " adlı oyunu " + game.UnitPrice + " TL Fiyat ile satın aldı");
            }
        }
    }
}
