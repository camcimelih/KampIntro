using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("oyun eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("oyun silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine("oyun güncellendi");
        }
    }
}
