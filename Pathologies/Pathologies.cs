using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathologies
{
    class CPathologies : ObservableCollection<Pathologie>
    {
        SqlLiteManager sq = new SqlLiteManager();

        public CPathologies()
        {
            List<Pathologie> list = sq.GetAllPathologies();
            if (list != null)
            {
                foreach (Pathologie pat in list)
                {
                    Add(pat);
                }
            }
        }
    }
}
