using ClaseAcceso;
using ClaseModelo.Dto.Login;
using ClaseNegocio.AuthBs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseServicio.Services
{
    public class AuthService
    {
        private readonly AcopioDbContext _context;
        private readonly AuthBusiness _business;
        public AuthService(AcopioDbContext context)
        {
            _context = context;
            _business = new AuthBusiness();
        }

        public LoginDto login(LoginBodyDto value)
        {
            try
            {
                Usuario usuarioEncontrado = _context.Usuarios.FirstOrDefault(x => x.UserName == value.UserName);
                return _business.login(usuarioEncontrado, value);
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
