using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opsummering
{
    class Character
    {
        private string CharacterName;


        public Character(string CharacterName)
        {
            this.CharacterName = CharacterName;
        }

        public string Person()
        {
            return "Hello" + CharacterName + "\n" +
                "this character has some stats" + "\n" +
                "type 1 to see them";
        }
    }
}
