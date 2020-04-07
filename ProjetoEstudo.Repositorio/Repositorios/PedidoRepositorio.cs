using ProjetoEstudo.Dominio.Contratos;
using ProjetoEstudo.Dominio.Entidades;
using ProjetoEstudo.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(ProjetoEstudoContexto projetoEstudoContexto) : base(projetoEstudoContexto)
        {
        }
    }
}
