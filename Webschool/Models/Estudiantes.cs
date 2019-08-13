using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webschool.Models
{
    public class Estudiantes
    {
        #region Contructor
            public Estudiantes(int id)
            {
                
            }
            public Estudiantes(int Grado,int top=100)
            {
                
            }
            public Estudiantes()
            {
                
            }
        #endregion

        #region Propiedades
            public int IdEstudiante {get;set;}
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public DateTime Nacimiento { get; set; }
            public int Grado { get; set; }
            public int IdSeccion { get; set; }
            public string Direccion { get; set; }

        #endregion

        #region List
            public List<Estudiantes> ListEstudiante {get;set;}
            public List<SelectListItem> Gradoes { get; } = Grados.Gradoes;

        #endregion

        #region Metodos


        #endregion



    }
}