using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPlanilla_CS_4DS_2024.bean
{
    internal class Empleado
    {
        #region Propiedades
        public int id { get; set; }
        public string Dni { get; set; }
        public string Ruc { get; set; }
        public string Nombres { get; set; }
        public string ApellidoMaterno { get; set; }
        public string ApellidoPaterno { get; set; }
        public string FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Correo  { get; set; }
        public string Celular { get; set; }
        public string Passwordd { get; set; }
        public int idDomiciliado { get; set;}
        public int idEstadoCivil { get; set; }
        public int idNivelEducativo { get; set; }
        public int idDepartamento { get; set; }
        public int idProvincia { get; set; }
        public int idDistrito { get; set; }
        #endregion

        #region Métodos

        #endregion
    }
}
