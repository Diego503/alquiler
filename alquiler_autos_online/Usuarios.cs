//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace alquiler_autos_online
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public int IdRole { get; set; }
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }
    
        public virtual Roles Roles { get; set; }
    }
}
