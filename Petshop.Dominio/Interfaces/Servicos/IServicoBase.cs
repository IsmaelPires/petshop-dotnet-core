﻿using Petshop.Dominio.Entidades;
using System.Collections.Generic;

namespace Petshop.Dominio.Interfaces.Servicos
{
    public interface IServicoBase<TEntidade>
        where TEntidade : EntidadeBase
    {
        int Incluir(TEntidade entidade);
        void Excluir(int id);
        void Excluir(TEntidade entidade);
        void Alterar(TEntidade entidade);
        TEntidade SelecionarPorId(int id);
        IEnumerable<TEntidade> SelecionarTodos();
    }
}
