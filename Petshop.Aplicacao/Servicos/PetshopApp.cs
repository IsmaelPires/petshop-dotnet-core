using AutoMapper;
using Petshop.Aplicacao.Servicos;
using Petshop.Aplicacao.DTO;
using Petshop.Aplicacao.Interfaces;
using Petshop.Dominio.Entidades;
using Petshop.Dominio.Interfaces.Servicos;
using Petshop.Dominio.Servicos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Petshop.Aplicacao.Servicos
{
    public class PetshopApp : ServicoAppBase<Petshop, PetshopoDTO>, IPetshopApp
{
        public PetshopApp(IMapper iMapper, IPetshopServico servico)
            : base(iMapper, servico)
        {

        }
    }
}