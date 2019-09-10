﻿using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class TituloPagarRepository : ITituloPagarRepository
    {
        public SistemaContext context;

        public TituloPagarRepository()
        {
            context = new SistemaContext();
        }

        public bool Alterar(TituloPagar tituloPagar)
        {

            var tituloPagarOficial = context.TitulosPagar.FirstOrDefault(x => x.Id == tituloPagar.Id);
            if (tituloPagar == null)
                return false;

            tituloPagarOficial.IdCategoriaDepesesa = tituloPagarOficial.IdCategoriaDepesesa;
            tituloPagarOficial.IdFornecedor = tituloPagarOficial.IdFornecedor;
            tituloPagarOficial.Descricao = tituloPagarOficial.Descricao;
            tituloPagarOficial.FormaPagamento = tituloPagarOficial.FormaPagamento;
            tituloPagarOficial.Caixa = tituloPagarOficial.Caixa;
            tituloPagarOficial.ValorTotal = tituloPagarOficial.ValorTotal;
            tituloPagarOficial.Status = tituloPagarOficial.Status;
            tituloPagarOficial.DataLancamento = tituloPagarOficial.DataLancamento;
            tituloPagarOficial.DataRecebimento = tituloPagarOficial.DataRecebimento;
            tituloPagarOficial.DataVencimento = tituloPagarOficial.DataVencimento;
            tituloPagarOficial.Complemento = tituloPagarOficial.Complemento;
            tituloPagarOficial.QuantidadeParcela = tituloPagarOficial.QuantidadeParcela;

            int quantidadeAfetada = context.SaveChanges();
            return quantidadeAfetada == 1;

        }

        public bool Apagar(int id)
        {
            var tituloPagar = context.TitulosPagar.FirstOrDefault(x => x.Id == id);
            if (tituloPagar == null)
            {
                return false;
            }

            tituloPagar.RegistroAtivo = false;
            int quantidadeAfetada = context.SaveChanges();
            return quantidadeAfetada == 1;
        }

        public int Inserir(TituloPagar tituloPagar)
        {
            context.TitulosPagar.Add(tituloPagar);
            context.SaveChanges();
            return tituloPagar.Id;
        }

        public TituloPagar ObterPeloId(int id)
        {
            var tituloPagar = context.TitulosPagar
                .Where(x => x.Id == id).FirstOrDefault();
            return tituloPagar;
        }

        public List<TituloPagar> ObterTodos()
        {
            return context.TitulosPagar.
                Where(x => x.RegistroAtivo == false).ToList();
        }
    }
}
