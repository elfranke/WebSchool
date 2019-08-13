using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webschool.Models
{
    public class Secciones
    {
        #region Contructor
            public Secciones  (int id)
            {
                
            }
            public Secciones (int grado,int top=40)
            {
                
            }
            public Secciones    ()
            {
                
            }
        #endregion

        #region Propiedades
            public int IdSeccion {get;set;}
            public string Seccion { get; set; }
            public int Grado { get; set; }
        #endregion

        #region List
            public List<Secciones> ListSeccion {get;set;}
            
        #endregion

        #region Metodos
        
            
        #endregion

    }
 
     }