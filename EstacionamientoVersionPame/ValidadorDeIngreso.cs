using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoVersionPame
{
    internal class ValidadorDeIngreso
    {
        public bool validarIngreso(string usuario, string pass)
        {
            if (usuario == "Admin" && pass == "1234")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
