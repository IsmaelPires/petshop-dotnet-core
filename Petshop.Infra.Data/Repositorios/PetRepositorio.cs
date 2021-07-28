using Petshop.Dominio.Entidades;
using Petshop.Dominio.Interfaces.Repositorios;
using Petshop.Infra.Data.Contextos;
namespace Petshop.Infra.Data.Repositorios
{
    public class PetRepositorio : RepositorioBasePet<Pet>, IPetRepositorio
    {
        public PetRepositorio(ContextoPet contexto)
            : base(contexto)
        {
        }
    }
}
