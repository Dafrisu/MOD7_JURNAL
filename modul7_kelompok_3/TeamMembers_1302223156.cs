using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_3
{
    internal class TeamMembers_1302223156
    {
        public class member
        {
            public string firstname { get; set; }
            public string lastname { get; set; }
            public string gender { get; set; }
            public string age { get; set; }
            public string nim { get; set; }
        }

        public class kelompok
        {
            public List<member> members { get; set; }
        }
    }

}
