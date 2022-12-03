using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SisMat_ADO;
using SisMat_BE;

namespace SisMat_BL
{
    public class BloqueBL
    {
        BloqueADO objBloqueADO = new BloqueADO();

        public DataTable ConsultarBloquesVacantes(Int16 vacantes)
        {
            return objBloqueADO.ConsultarBloquesVacantes(vacantes);
        }
    }
}
