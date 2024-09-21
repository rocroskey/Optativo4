using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Usuario
{
    internal class usuarioModel
    {
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set;}
        public string Contraseña { get; set; }
        public DateTime FechaRegsitro { get; set; }

       
    }
}
