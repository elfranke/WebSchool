using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webschool.Models
{
    public class Periodos
    {
        #region Contructor
            public Periodos(int id)
            {
                
            }
            public Periodos(int IdMateria,int Grado)
            {
                
            }
            public Periodos()
            {
                
            }
        #endregion

        #region Propiedades
            public int IdPeriodo {get;set;}
            public string Periodo { get; set; }
            public string Meses { get; set; }
        #endregion

        #region List
            public List<Periodos> ListPeriodo {get;set;}
            
        #endregion

        #region Metodos
        
            
        #endregion

   
 
     }
}