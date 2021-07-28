using Petshop.Aplicacao.Interfaces;
using Petshop.Aplicacao.Servicos;
using Petshop.Dominio.Interfaces.Repositorios;
using Petshop.Dominio.Interfaces.Servicos;
using Petshop.Dominio.Servicos;
using Petshop.Infra.Data.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace Petshop.Infra.IoC
{
    public class InjetorDependencias
    {
        public static void Registrar(IServiceCollection svcCollection)
        {
            //Aplicação
            svcCollection.AddScoped(typeof(IAppBase<,>), typeof(ServicoAppBase<,>));
            svcCollection.AddScoped<IPetApp, PetApp>();
            svcCollection.AddScoped<IPetshopApp, PetshopApp>();

            //Domínio
            svcCollection.AddScoped(typeof(IServicoBase<>), typeof(ServicoBase<>));
            svcCollection.AddScoped<IPetServico, PetServico>();
            svcCollection.AddScoped<IPetshopServico, PetshopServico>();

            //Repositorio
            svcCollection.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBasePet<>));
            svcCollection.AddScoped<IPetRepositorio, PetRepositorio>();

            svcCollection.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBasePetshop<>));
            svcCollection.AddScoped<IPetshopRepositorio, PetshopRepositorio>();
        }
    }
}
