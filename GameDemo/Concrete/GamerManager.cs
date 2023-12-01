
using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("kayıt işlemi başarılı");
            }
            else
            {
                Console.WriteLine("doğrulama başarısız , kayıt başarısız ");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("silme işlemi başarılı");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("güncelleme işlemi başarılı");
        }
    }
}
