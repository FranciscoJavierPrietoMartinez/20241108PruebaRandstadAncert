using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AncertCrono
{
    class CronoViewModel
    {
        Crono _crono = null;

        public CronoViewModel()
        {
            _crono = new Crono();
        }

        public Crono MyCrono
        {
            get { return _crono; }
        }
    }
}
