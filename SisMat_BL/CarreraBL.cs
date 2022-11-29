using SisMat_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMat_BE
{
    public class CarreraBL
    {
        CarreraADO carreraADO = new CarreraADO();
        public DataTable ListarCarrera()
        {
            return carreraADO.ListarCarrera();
        }
    }
}
