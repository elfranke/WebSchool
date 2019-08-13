using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webschool.Models
{
    public class Evaluaciones
    {
        #region Contructor
            public Evaluaciones(int id)
            {
                
            }
            public Evaluaciones(int Grado,int top=100)
            {
                
            }
            public Evaluaciones()
            {
                
            }
        #endregion

        #region Propiedades
            public int IdEvaluacion {get;set;}
            public int IdEstudiante {get;set;}
            public string Estudiante { get; set; }
            public int IdSeccion {get;set;}
            public int IdIndicador {get;set;}
            public string Indicador { get; set; }
            public int IdMateria { get; set; }
            public string Materia { get; set; }
            public int IdPeriodo { get; set; }
            public string Periodo { get; set; }
            public int Grado { get; set; }
            public string Descripcion { get; set; }
            public DateTime Fecha {get;set;}
        #endregion

        #region List
            public List<Evaluaciones> ListEvaluacion {get;set;}
            
        #endregion

        #region Metodos
        
            
        #endregion

   
 
     }
}