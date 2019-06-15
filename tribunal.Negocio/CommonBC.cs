using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tribunal.DALC;

namespace tribunal.Negocio
{
    public class CommonBC
    {
        private static LexEntities _lexEntities;

        public static LexEntities LexEntities {

            get {

                if (_lexEntities == null) {

                    _lexEntities = new LexEntities();

                }

                return _lexEntities;

            }

        }
    }
}
