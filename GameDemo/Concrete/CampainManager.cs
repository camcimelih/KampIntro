using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class CampainManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("kampanya eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("kampanya güncellendi");
        }
    }
}
