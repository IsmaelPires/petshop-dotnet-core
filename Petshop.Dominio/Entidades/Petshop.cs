using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop.Dominio.Entidades
{
    public class Petshop : EntidadeBase
    {
        public string Nome { get; set; }

        public string Peso { get; set; }

        public string Altura { get; set; }

        public string Imc { get; set; }
    }
}
