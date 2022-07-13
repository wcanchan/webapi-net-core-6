using ClaseAcceso;
using ClaseModelo.Dto.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNegocio.AuthBs
{
    public class AuthBusiness
    {
        public LoginDto login(Usuario? usuarioEncontrado, LoginBodyDto value)
        {
            LoginDto loginDto = new LoginDto();
            bool validacionPassword = true; // BCrypt.Net.BCrypt.Verify(usuarioEncontrado.Password, value.password);
            if (validacionPassword)
            {
                loginDto.token = generarToken(usuarioEncontrado);
                loginDto.tipoToken = "Bearer";
                loginDto.mensaje = "Ok";
            }
            return loginDto;
        }

        private string generarToken(Usuario usuarioEncontrado)
        {
            return "JVTJJHSDFHJHDDFHDHFGJSDGHFJHSGFH";
        }
    }
}
