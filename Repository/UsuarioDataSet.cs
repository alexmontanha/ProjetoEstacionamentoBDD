using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UsuarioDataSet
    {
        public Dictionary<string, string> Usuarios = new Dictionary<string, string>();

        public UsuarioDataSet()
        {
            Usuarios.Add("Alex", "123");
            Usuarios.Add("Copilot", "953");
            Usuarios.Add("Lulu", "456");
        }
        // Criar um método para adicionar um usuário
        // Criar um método para retornar um usuário pelo Id
        public string? FindUsuario(string nome)
        {
            try
            {
                return Usuarios[nome];
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
