using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VlaamiAuto
{
    class Szemely
    {
        public Guid Guid { get; set; }
        public string Nev { get; set; }

        public override string ToString() =>
                        $"[GUID: {Guid}] {Nev}";
    
        public Szemely(string nev)
        {
            Guid = Guid.NewGuid();
            Nev = nev;
        }
    }
}
