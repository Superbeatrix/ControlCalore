using System;

namespace TCC.Models.InputModel
{
    public class Usuario
    {
        public long UsuarioId { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public short QtdCaloriasDiarias { get; set; } //1000 - %75 => 750

        public short QtdCaloriasSemanais { get; set; } //5000

        public short PerfilId { get; set; }

        public bool Ativo { get; set; }
    }
}
