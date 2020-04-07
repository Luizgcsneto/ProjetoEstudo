using ProjetoEstudo.Dominio.Contratos;
using ProjetoEstudo.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoEstudo.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {

        protected readonly ProjetoEstudoContexto ProjetoEstudoContexto;

        public BaseRepositorio(ProjetoEstudoContexto projetoEstudoContexto)
        {
            ProjetoEstudoContexto = projetoEstudoContexto;
        }

        public void Adicionar(TEntity tentity)
        {
            ProjetoEstudoContexto.Set<TEntity>().Add(tentity);
            ProjetoEstudoContexto.SaveChanges();
        }

        public void Atualizar(TEntity tentity)
        {
            ProjetoEstudoContexto.Set<TEntity>().Update(tentity);
            ProjetoEstudoContexto.SaveChanges();
        }

       

        public TEntity ObterPorId(int id)
        {
            return ProjetoEstudoContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
          return ProjetoEstudoContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity tentity)
        {
            ProjetoEstudoContexto.Remove(tentity);
            ProjetoEstudoContexto.SaveChanges();
        }

        public void Dispose()
        {
            ProjetoEstudoContexto.Dispose();
        }
    }
}
