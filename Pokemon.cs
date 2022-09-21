using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class Pokemon
    {
        string name;
        string type;
        int currentForm;
        int totalForms;

        public Pokemon(string name, string type, int currentForm, int totalForms)
        {
            this.name = name;
            this.type = type;
            this.currentForm = currentForm;
            this.totalForms = totalForms;
        }
    }
}
