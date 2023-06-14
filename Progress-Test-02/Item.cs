using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Test_02
{
    internal class Item
    {
        public string WordId { get; set; }
        public string Word { get; set; }
        public string Meaning { get; set; }
        public string EditDate { get; set; }
        public string TypeName { get; set; }

        public Item(string wordId, string word, string meaning, string editDate, string typeName)
        {
            WordId = wordId;
            Word = word;
            Meaning = meaning;
            EditDate = editDate;
            TypeName = typeName;
        }
        public Item()
        {
            
        }
    }

}
