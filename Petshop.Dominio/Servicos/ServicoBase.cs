using Petshop.Dominio.Entidades;
using Petshop.Dominio.Interfaces.Repositorios;
using Petshop.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop.Dominio.Servicos
{
    public class ServicoBase<TEntidade> : IServicoBase<TEntidade>
where TEntidade : EntidadeBase
{
        protected readonly IRepositorioBase<TEntidade> repositorio;

        public ServicoBase(IRepositorioBase<TEntidade> repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Alterar(TEntidade entidade)
        {
            repositorio.Alterar(entidade);
        }

        public void Excluir(int id)
        {
            repositorio.Excluir(id);
        }

        public void Excluir(TEntidade entidade)
        {
            repositorio.Excluir(entidade);
        }

        public int Incluir(TEntidade entidade)
        {
            return repositorio.Incluir(entidade);
        }

        public TEntidade SelecionarPorId(int id)
        {
            return repositorio.SelecionarPorId(id);
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return repositorio.SelecionarTodos();
        }

    }
}
