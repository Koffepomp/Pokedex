using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class Pokemon
    {
        string name1;
        string name2;
        string name3;
        string type;
        int currentForm;
        int totalForms;
        string desc;

        public Pokemon(string name1, string name2, string name3, string type, int currentForm, int totalForms, string desc)
        {
            this.name1 = name1;
            this.name2 = name2;
            this.name3 = name3;
            this.type = type;
            this.currentForm = currentForm;
            this.totalForms = totalForms;
            this.desc = desc;
        }

        public string Name()
        {
            if (currentForm == 1)
                return name1;
            else if (currentForm == 2)
                return name2;
            else
                return name3;
        }
        public string AllNames()
        {
            string allNames = $" ({name1}, {name2}, {name3})";
            return allNames;
        }

        public string Type()
        {
            return type;
        }

        public int CurrentForm()
        {
            return currentForm;
        }

        public int TotalForms()
        {
            return totalForms;
        }

        public string Desc()
        {
            return desc;
        }
    }
}
