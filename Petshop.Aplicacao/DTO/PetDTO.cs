using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop.Aplicacao.DTO
{
    public class PetDTO : BaseDTO
    {
        public string Nome { get; set; }
        public string Peso { get; set; }
        public string Idade { get; set; }
        public string Raca { get; set; }
    }
}
