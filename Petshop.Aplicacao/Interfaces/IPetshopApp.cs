using Petshop.Aplicacao.DTO;
using Petshop.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Petshop.Aplicacao.Interfaces
{
    public interface IPetshopApp : IAppBase<Dominio.Entidades.Petshop, PetshopDTO>
    {

    }
}
