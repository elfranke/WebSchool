using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webschool.Models
{
    public class Asistencias
    {
        #region Contructor
        public Asistencias(int id)
        {

        }
        public Asistencias(int IdMateria, int Grado)
        {

        }
        public Asistencias()
        {
            Fecha = DateTime.Now;
        }
        #endregion

        #region Propiedades
        public int IdAsistencia { get; set; }
        public int Asistencia { get; set; }
        public int IdEstudiante { get; set; }
        public string Estudiante { get; set; }
        public int IdMateria { get; set; }
        public string Materia { get; set; }
        public DateTime Fecha { get; set; }
        #endregion

        #region List
        public List<Asistencias> ListIndicador { get; set; }

        #endregion

        #region Metodos


        #endregion



    }
}
