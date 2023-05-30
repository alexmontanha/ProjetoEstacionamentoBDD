using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace CasosDeUso
{
    public class Login
    {
        private UsuarioDataSet _usuarioDataSet;

        public Login(string usuario, string senha, UsuarioDataSet usuarioDataSet)
        {
            Usuario = usuario;
            Senha = senha;
            _usuarioDataSet = usuarioDataSet;
        }

        /// <summary>
        /// Autentica o usuário
        /// Se Ok retor um id, se não retorna 0
        /// </summary>
        /// <returns>id</returns>
        public int Authenticate()
        {
            var senha = _usuarioDataSet.FindUsuario(Usuario);
            return senha != null && senha == Senha ? 1 : 0;
        }

        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}
