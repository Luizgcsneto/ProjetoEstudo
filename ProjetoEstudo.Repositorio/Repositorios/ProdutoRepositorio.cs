using ProjetoEstudo.Dominio.Contratos;
using ProjetoEstudo.Dominio.Entidades;
using ProjetoEstudo.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(ProjetoEstudoContexto projetoEstudoContexto) : base(projetoEstudoContexto)
        {

        }
    }
}
