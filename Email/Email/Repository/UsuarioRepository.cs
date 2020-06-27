using Email.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Email.Repository
{
    public class UsuarioRepository
    {
        public static UsuarioModel Get(string Email, string Senha) {
            var Usuarios = new List<UsuarioModel>();
            Usuarios.Add(new UsuarioModel {
                Nome = "Nayara",
                Email = "nayara@gmail.com",
                Senha = "123456",
                Nascimento = "17/02/1992"
            });
            Usuarios.Add(new UsuarioModel { 
                Nome = "Claudia", 
                Email ="claudia@gmail.com",
                Senha = "123456",
                Nascimento = "09/04/1992"
            });
            return Usuarios.Where(x => x.Email.ToLower() == Email && x.Senha.ToLower() == Senha).FirstOrDefault();
        }
    }
}
