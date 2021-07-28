using AutoMapper;
using Petshop.Aplicacao.DTO;
using Petshop.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Petshop.Aplicacao
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            CreateMap<Petshop, PetshopDTO>();

            CreateMap<Petshop, PetDTO>();
        }
    }
}
