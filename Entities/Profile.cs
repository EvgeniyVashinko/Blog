using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Profile : EntityBase
    {
        public string ImagePath { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
