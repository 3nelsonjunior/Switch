using System;
using Switch.Domain.Enums;

namespace Switch.Domain.Entities
{
    public class Usuario
    {
        public int id { get; private set; }
        public string nome { get; set; }
        public string sobreNome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public DateTime dataNascimento { get; set; }
        public SexoEnum sexo { get; set; }
        public string urlFoto { get; set; }
    }
}
