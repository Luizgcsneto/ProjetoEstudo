using ProjetoEstudo.Dominio.Contratos;
using ProjetoEstudo.Dominio.Entidades;
using ProjetoEstudo.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(ProjetoEstudoContexto projetoEstudoContexto) : base(projetoEstudoContexto)
        {
        }

        public void Adicionar(Usuario tentity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Usuario tentity)
        {
            throw new NotImplementedException();
        }

        public void Remover(Usuario tentity)
        {
            throw new NotImplementedException();
        }

        Usuario IBaseRepositorio<Usuario>.ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Usuario> IBaseRepositorio<Usuario>.ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
