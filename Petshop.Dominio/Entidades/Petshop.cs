using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop.Dominio.Entidades
{
    public class Petshop : EntidadeBase
    {
        public string Nome { get; set; }

        public string Endereco { get; set; }

        public int QuantidadeVagas { get; set; }
    }
}
