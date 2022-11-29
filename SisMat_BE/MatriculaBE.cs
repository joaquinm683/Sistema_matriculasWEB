using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMat_BE
{
    public class MatriculaBE
    {
        public Int16 Id_matricula { get; set; }
        public Int16 Id_semestre { get; set; }
        public Int16 Id_carrera { get; set; }
        public Int16 Id_alum { get; set; }
        public String Usu_Registro { get; set; }
        public DateTime Fec_reg { get; set; }
        public String Usu_Ult_Mod { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
        public Int16 Est_matricula { get; set; }
    }
}
