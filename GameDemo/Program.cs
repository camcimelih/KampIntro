using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager= new GamerManager(new UserValidationManager());
            gamerManager.Add(new Entities.Gamer { Id = 1,FirstName="MELİH",LastName="CAMCI",DateOfBirth =new DateTime (2001,10,3),NationalityId=98765 });
            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.Name = "black friday";
            campaign1.DiscountRate = 25;

            Campaign campaign2 = new Campaign();
            campaign2.Id = 2;
            campaign2.Name = " sevgililer günü";
            campaign2.DiscountRate = 20;
            Campaign campaign3 = new Campaign();
            campaign3.Id = 3;
            campaign3.Name = "babalar günü";
            campaign3.DiscountRate = 30;
            CampainManager campaignManager = new CampainManager();
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign2);
            campaignManager.Update(campaign3);

            GameManager gameManager = new GameManager();
            gameManager.Add(new Game { Id = 1, Name = "gta", UnitPrice = 100, Campaign = campaign1 });
            gameManager.Delete(new Game { Id = 2, Name = "need for speed", UnitPrice = 150, Campaign = campaign2 });
            gameManager.Update(new Game { Id = 3, Name = "tennis", UnitPrice = 200, Campaign = campaign3 });
            Game game1 = new Game();
            game1.Id=1; game1.Name = "gta";game1.UnitPrice = 100;game1.Campaign= campaign1;

            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "MELİH";
            gamer1.LastName = "CAMCI";
            gamer1.DateOfBirth = new DateTime(2001, 10, 3);
            gamer1.PurchasedGame = game1;
            Game game2 = new Game();
            game2.Id=1; game2.Name = "need for speed"; game2.UnitPrice = 150;



            
            
            OrderManager orderManager = new OrderManager();
            orderManager.SellGame(gamer1,game1);
            OrderManager orderManager2 = new OrderManager();
            orderManager2.SellGame(gamer1 ,game2);


        }
    }
}
