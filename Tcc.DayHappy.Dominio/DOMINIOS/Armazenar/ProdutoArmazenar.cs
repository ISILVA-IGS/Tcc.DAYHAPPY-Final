using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.DAL;
using Tcc.DayHappy.Dominio.Produtos;

namespace Tcc.DayHappy.Dominio.Armazenar
{
    public class ProdutoArmazenar
    {
        private readonly IRepository<Produto> _produtoRepository;

        public ProdutoArmazenar(IRepository<Produto> produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
    
        public void Armazenar(int id , string nomeProduto, string faixaEtaria, string descricao,
            decimal valorLocacao, decimal valorCusto)
        {
            var produto = _produtoRepository.GetById(id);

            if(produto == null)
            {
                produto = new Produto(nomeProduto, faixaEtaria, descricao, valorLocacao, valorCusto);
               _produtoRepository.Create(produto);
            }
            else
            {
                produto.Update(nomeProduto, faixaEtaria, descricao, valorLocacao, valorCusto);
            }
        }

        public void Deletar(int id, string nomeProduto, string faixaEtaria, string descricao,
            decimal valorLocacao, decimal valorCusto)
        {
            var produto = _produtoRepository.GetById(id);

            if (produto.COD_PROD == id)
            {
                _produtoRepository.Delete(produto);
            }

        }
    }
}
