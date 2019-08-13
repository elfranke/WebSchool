using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webschool.Models
{
    public class Usuarios
    {
        #region Contructor
            public Usuarios(int id)
            {
                
            }
            public Usuarios(string us,string ps)
            {
                
            }
            public Usuarios()
            {
                
            }
        #endregion

        #region Propiedades
            public int Idusuario {get;set;}
            public string Usuario { get; set; }
            public string Nombre { get; set; }
            public string Tipo { get; set; }
        #endregion

        #region List
            public List<Usuarios> ListUsuario {get;set;}
            
        #endregion

        #region Metodos
        
            
        #endregion

   
 
     }
}