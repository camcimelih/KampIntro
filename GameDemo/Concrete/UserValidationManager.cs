using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.FirstName == "MELİH" && gamer.DateOfBirth.Year == 2001 && gamer.LastName == "CAMCI" && gamer.NationalityId == 98765) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
