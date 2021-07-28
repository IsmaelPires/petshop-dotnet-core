using Petshop.Dominio.Entidades;
using Petshop.Dominio.Interfaces.Repositorios;
using Petshop.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Petshop.Dominio.Servicos
{
    public class PetshopServico : ServicoBase<Petshop>, IPetshopServico
    {
        public PetshopServico(IPetshopRepositorio repositorio)
            : base(repositorio)
        {
        }
    }
}
