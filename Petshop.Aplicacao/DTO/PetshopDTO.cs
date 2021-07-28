using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop.Aplicacao.DTO
{
    public class PetshopDTO : BaseDTO
    {
        public string Nome { get; set; }

        public string Endereco { get; set; }
        public int QauntidadeVagas { get; set; }
        public string UrlFoto { get; set; }
    }
}
