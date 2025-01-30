
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLearner.Domain.Entities
{
    public class User : IdentityUser
    {
        public List<Dictionary> Dictionaries { get; set; } = new();
    }
}
