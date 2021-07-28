using Petshop.Dominio.Interfaces.Repositorios;
using Petshop.Infra.Data.Contextos;
namespace Petshop.Infra.Data.Repositorios
{
    public class PetshopRepositorio : RepositorioBasePetshop<Petshop.Dominio.Entidades.Petshop>, IPetshopRepositorio
    {
        public PetshopRepositorio(ContextoPetshop contexto)
            : base(contexto)
        {
        }
    }
}
