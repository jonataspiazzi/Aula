using System;

namespace entr1.Models
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Departamento { get; set; }

        public DateTime? DataNascimento { get; set; }

        public string TelefonePrimario { get; set; }

        public string TelefoneSecundario { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public bool AcessoAoIClips { get; set; }

        public bool AtivoNaAgencia { get; set; }
    }
}