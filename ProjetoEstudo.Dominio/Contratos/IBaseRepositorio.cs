using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity tentity);

        TEntity ObterPorId(int id);

        IEnumerable<TEntity> ObterTodos();

        void Atualizar(TEntity tentity);

        void Remover(TEntity tentity);
    }
}
