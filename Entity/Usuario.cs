namespace Entity
{
    public class Usuario
    {

        public Usuario(string nome, string sobrenome, string CPF, string telefone, string celular, string email, DateTime dataNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            this.CPF = CPF;
            Telefone = telefone;
            Celular = celular;
            Email = email;
            DataNascimento = dataNascimento;
        }

        private DateTime dataNascimento;

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Sexo { get; set; } //M ou F
        public string CPF { get; set; }
        public string? CNH { get; set; }

        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public DateTime DataNascimento
        {
            get => dataNascimento;
            set
            {
                if (value > DateTime.Now)
                {
                    throw new Exception("Data de nascimento não pode ser maior que a data atual.");
                }
                dataNascimento = value;
            }
        }
    }
}

