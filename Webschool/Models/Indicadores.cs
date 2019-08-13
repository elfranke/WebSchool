using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webschool.Models
{
    public class Indicadores
    {
        #region Contructor
            public Indicadores(int id)
            {
                
            }
            public Indicadores(int IdMateria,int Grado)
            {
                
            }
            public Indicadores()
            {
                
            }
        #endregion

        #region Propiedades
            public int IdIndicador {get;set;}
            public string Indicador { get; set; }
            public int Grado { get; set; }
            public int IdMateria { get; set; }
        #endregion

        #region List
            public List<Indicadores> ListIndicador {get;set;}
            
        #endregion

        #region Metodos
        
            
        #endregion

   
 
     }
}