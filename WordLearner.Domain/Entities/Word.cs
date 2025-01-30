using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLearner.Domain.Entities
{
    public class Word
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Translation { get; set; }
        public string Example { get; set; }
        public int DictionaryId { get; set; }
        public Dictionary Dictionary { get; set; }
    }
}
