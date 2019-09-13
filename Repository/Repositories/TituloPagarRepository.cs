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

            var tituloPagarOficial = context.TitulosPagar.Where(x => x.Id == tituloPagar.Id).FirstOrDefault();
            if (tituloPagar == null)
            {
                return false;
            }

            tituloPagarOficial.IdCategoriaDespesa = tituloPagar.IdCategoriaDespesa;
            tituloPagarOficial.IdFornecedor = tituloPagar.IdFornecedor;
            tituloPagarOficial.Descricao = tituloPagar.Descricao;
            tituloPagarOficial.FormaPagamento = tituloPagar.FormaPagamento;
            tituloPagarOficial.Caixa = tituloPagar.Caixa;
            tituloPagarOficial.ValorTotal = tituloPagar.ValorTotal;
            tituloPagarOficial.Status = tituloPagar.Status;
            tituloPagarOficial.DataLancamento = tituloPagar.DataLancamento;
            tituloPagarOficial.DataRecebimento = tituloPagar.DataRecebimento;
            tituloPagarOficial.DataVencimento = tituloPagar.DataVencimento;
            tituloPagarOficial.Complemento = tituloPagar.Complemento;
            tituloPagarOficial.QuantidadeParcela = tituloPagar.QuantidadeParcela;

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
            tituloPagar.RegistroAtivo = true;
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
                Where(x => x.RegistroAtivo == true).ToList();
        }
    }
}
