using SisMat_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMat_BL
{
    public class SemestreBL
    {
        SemestreADO semestreADO = new SemestreADO();
        public DataTable ListarSemestre()
        {
            return semestreADO.ListaSemestre();
        }
    }
}
