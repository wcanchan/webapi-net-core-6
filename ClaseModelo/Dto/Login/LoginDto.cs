using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseModelo.Dto.Login
{
    public class LoginDto
    {
        public string token { get; set; }
        public string tipoToken { get; set; }
        public string mensaje { get; set; }
    }
}
