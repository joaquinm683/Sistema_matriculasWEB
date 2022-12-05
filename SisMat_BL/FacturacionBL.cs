using SisMat_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMat_BL
{
    public class FacturacionBL
    {
        FacturacionADO objFacturacionADO = new FacturacionADO();

        public DataTable ListarFacturaAnual()
        {
            return objFacturacionADO.ListarFacturaAnual();
        }
    }
}
