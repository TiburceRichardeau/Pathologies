using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathologies
{

    class Pathologie
    {
        public string id { get; set; }
        public string nom { get; set; }
        public string causes { get; set; }
        public string symptomes { get; set; }
        public string approche_alimentaire { get; set; }
        public string complements_alimentaires { get; set; }
        public string autre_approche { get; set; }

        public Pathologie(string i, string n, string ca, string s, string a, string co, string au)
        {
            id = i;
            nom = n;
            causes = ca;
            symptomes = s;
            approche_alimentaire = a;
            complements_alimentaires = co;
            autre_approche = au;
        }

        public Pathologie(string n, string ca, string s, string a, string co, string au)
        {
            nom = n;
            causes = ca;
            symptomes = s;
            approche_alimentaire = a;
            complements_alimentaires = co;
            autre_approche = au;
        }
    }
}
