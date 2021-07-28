﻿using AutoMapper;
using Petshop.Aplicacao.DTO;
using Petshop.Aplicacao.Interfaces;
using Petshop.Dominio.Entidades;
using Petshop.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop.Aplicacao.Servicos
{
    public class ServicoAppBase<TEntidade, TEntidadeDTO> : IAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : EntidadeBase
        where TEntidadeDTO : BaseDTO
    {
        protected readonly IServicoBase<TEntidade> servico;
        protected readonly IMapper iMapper;

        public ServicoAppBase(IMapper iMapper, IServicoBase<TEntidade> servico)
            : base()
        {
            this.iMapper = iMapper;
            this.servico = servico;
        }

        public void Alterar(TEntidadeDTO entidade)
        {
            servico.Alterar(iMapper.Map<TEntidade>(entidade));
        }

        public void Excluir(int id)
        {
            servico.Excluir(id);
        }

        public void Excluir(TEntidadeDTO entidade)
        {
            servico.Excluir(iMapper.Map<TEntidade>(entidade));
        }

        public int Incluir(TEntidadeDTO entidade)
        {
            return servico.Incluir(iMapper.Map<TEntidade>(entidade));
        }

        public TEntidadeDTO SelecionarPorId(int id)
        {
            return iMapper.Map<TEntidadeDTO>(servico.SelecionarPorId(id));
        }

        public IEnumerable<TEntidadeDTO> SelecionarTodos()
        {
            return iMapper.Map<IEnumerable<TEntidadeDTO>>(servico.SelecionarTodos());
        }
    }
}
