using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1.Entities.Concrete
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateofBirthYear { get; set; }
        public long NationalIdenty { get; set; }
        public string Email { get; set; }
        public string NickName { get; set; }
    }
}
