using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opsummering
{
    class Attribute : Character
    {
        private string name;

        public Attribute(string name) : base(name)

        {
            this.name = name;
        }

        public string Describe()
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
