using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLearner.Domain.Entities
{
    public class Dictionary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId {  get; set; }
        public User User { get; set; }
        public List<Word> Words { get; set; } = new();
    }
}
