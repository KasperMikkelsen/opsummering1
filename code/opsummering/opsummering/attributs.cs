using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opsummering
{
    class attribute : Character
    {
        private string name;

        public attribute(string name) : base(Character)

        {
            this.name = name;
        }

        public new string Describe()
        {
            return "This is the attributes of " + name;
        }

        public string CharacterName
        {
            get { return name; }
            set { name = value; }
        }
    }
}
