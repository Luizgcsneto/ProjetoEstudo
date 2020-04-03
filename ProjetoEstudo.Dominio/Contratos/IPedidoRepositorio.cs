using ProjetoEstudo.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Dominio.Contratos
{
    public interface IPedidoRepositorio : IBaseRepositorio<Pedido>
    {
        public void Adicionar(Pedido tentity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Pedido tentity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Pedido ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(Pedido tentity)
        {
            throw new NotImplementedException();
        }
    }
}
