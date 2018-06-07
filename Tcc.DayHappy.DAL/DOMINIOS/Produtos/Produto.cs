using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.Dominio.Produtos
{
    public class Produto 
    {
        public int COD_PROD { get; private set; }
        public string NOME_PROD { get;  private set; }
        public decimal VALOR_LOCACAO_PROD { get; private set; }
        public decimal VALOR_CUSTO_PROD { get; private set; }
        public string FAIXA_ETARIA_INDICADA { get; private set; }
        public string DESCRICAO_PROD { get; private set; }

        protected Produto() { }

        public Produto(string nomeProduto, string faixaEtaria, string descricao,
            decimal valorLocacao, decimal valorCusto)
        {
            ValidacaoValoresSetPropriedades(nomeProduto, faixaEtaria, descricao, valorLocacao, valorCusto);
        }

        //Lembrar de rever todos os tratamentos--> data compra
        //(ATENÇÃO) com check list de pecas é obrigatorio ???
        private  void ValidacaoValoresSetPropriedades(string nomeProduto, string faixaEtaria, string descricao, 
            decimal valorLocacao, decimal valorCusto)
        {
            DomainException.Quando(string.IsNullOrEmpty(nomeProduto), "Nome do Produto é obrigatorio");
            DomainException.Quando(nomeProduto.Length < 1, "Nome do produto Invalido");
            DomainException.Quando(string.IsNullOrEmpty(faixaEtaria), "Faixa Etaria é obrigatoria");
            DomainException.Quando(faixaEtaria.Length < 1, "Faixa Etaria Invalida");
            DomainException.Quando(valorLocacao < 0, "Valor Locação Invalido");
            DomainException.Quando(valorCusto < 0, "Valor Locação Invalido");
            // DomainException.Quando(string.IsNullOrEmpty(checkListPecas),"Check List das Pecas é Obrigatorio")
            NOME_PROD = nomeProduto;
            FAIXA_ETARIA_INDICADA = faixaEtaria;
            DESCRICAO_PROD = descricao;
            VALOR_LOCACAO_PROD = valorLocacao;
            VALOR_CUSTO_PROD = valorCusto;


        }

        public void Update(string nomeProduto, string faixaEtaria, string descricao,
            decimal valorLocacao, decimal valorCusto)
        {
            ValidacaoValoresSetPropriedades(nomeProduto, faixaEtaria, descricao, valorLocacao, valorCusto);
        }
    }
}
