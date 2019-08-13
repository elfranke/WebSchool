using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webschool.Models
{
    public class Materias
    {
        #region Contructor
            public Materias(int id)
            {
                
            }
            public Materias(int grado,int top=40)
            {
                
            }
            public Materias()
            {
                
            }
        #endregion

        #region Propiedades
            public int IdMateria {get;set;}
            public string Materia { get; set; }
            public int Grado { get; set; }
        #endregion

        #region List
            public List<Materias> ListMateria {get;set;}
            
        #endregion

        #region Metodos
        
            
        #endregion

   
 
     }
}