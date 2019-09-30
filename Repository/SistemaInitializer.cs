﻿using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Repository
{
    internal class SistemaInitializer : CreateDatabaseIfNotExists<SistemaContext>
 //   internal class SistemaInitializer : DropCreateDatabaseAlways<SistemaContext>
    {
        protected override void Seed(SistemaContext context)
        {

            #region agencias
            var agencias = new List<Agencia>();
            agencias.Add(new Agencia()
            {
                NomeAgencia = "Agencia da Vida",
                NumeroAgencia = 2001,
                Banco = "Banco de Vida",
                RegistroAtivo = true
            });
            agencias.Add(new Agencia()
            {
                NomeAgencia = "Agencia do Paulo",
                NumeroAgencia = 666,
                Banco = "Banco do Paulo",
                RegistroAtivo = true
            });

            agencias.Add(new Agencia()
            {
                NomeAgencia = "Você consegue",
                NumeroAgencia = 8001,
                Banco = "Banco do Goku",
                RegistroAtivo = true,
            });
            context.Agencias.AddRange(agencias);

            #endregion



            #endregion

            #region caixa


            var caixas = new List<Caixa>();
            caixas.Add(new Caixa()
            {
                Id = 1,
                Operacao = "Entrada",
                Descricao = "recebimento serviço",
                Documento = "171-1",
                FormaPagamento = "Debito",
                Valor = 1500,
                DataLancamento = Convert.ToDateTime("2019-01-02"),
                IdHistoricos = 1,
                RegistroAtivo = true
            });
            caixas.Add(new Caixa()
            {
                Id = 2,
                Operacao = "Saida",
                Descricao = "Pagamento Energia",
                Documento = "172-1",
                FormaPagamento = "Debito",
                Valor = 36,
                DataLancamento = Convert.ToDateTime("2019-01-02"),
                IdHistoricos = 1,
                RegistroAtivo = true
            });
            caixas.Add(new Caixa()
            {
                Id = 3,
                Operacao = "Entrada",
                Descricao = "Recebimento serviço",
                Documento = "173-1",
                FormaPagamento = "Debito",
                Valor = 1900,
                DataLancamento = Convert.ToDateTime("2019-01-02"),
                IdHistoricos = 1,
                RegistroAtivo = true
            });
            caixas.Add(new Caixa()
            {
                Id = 4,
                Operacao = "Entrada",
                Descricao = "Recebimento serviço",
                Documento = "174-1",
                FormaPagamento = "Debito",
                Valor = 60,
                DataLancamento = Convert.ToDateTime("2019-01-03"),
                IdHistoricos = 1,
                RegistroAtivo = true
            });
            caixas.Add(new Caixa()
            {
                Id = 5,
                Operacao = "Entrada",
                Descricao = "Recebimento serviço",
                Documento = "175-1",
                FormaPagamento = "Debito",
                Valor = 100,
                DataLancamento = Convert.ToDateTime("2019-01-03"),
                IdHistoricos = 1,
                RegistroAtivo = true
            });
            caixas.Add(new Caixa()
            {
                Id = 6,
                Operacao = "Entrada",
                Descricao = "Recebimento serviço",
                Documento = "176-1",
                FormaPagamento = "Debito",
                Valor = 190,
                DataLancamento = Convert.ToDateTime("2019-01-03"),
                IdHistoricos = 1,
                RegistroAtivo = true
            });
            caixas.Add(new Caixa()
            {
                Id = 7,
                Operacao = "Entrada",
                Descricao = "Recebimento serviço",
                Documento = "177-1",
                FormaPagamento = "Debito",
                Valor = 650,
                DataLancamento = Convert.ToDateTime("2019-01-05"),
                IdHistoricos = 1,
                RegistroAtivo = true
            });
            caixas.Add(new Caixa()
            {
                Id = 8,
                Operacao = "Entrada",
                Descricao = "Recebimento serviço",
                Documento = "178-1",
                FormaPagamento = "Debito",
                Valor = 320,
                DataLancamento = Convert.ToDateTime("2019-01-05"),
                IdHistoricos = 1,
                RegistroAtivo = true
            });
            caixas.Add(new Caixa()
            {
                Id = 9,
                Operacao = "Entrada",
                Descricao = "Recebimento serviço",
                Documento = "179-1",
                FormaPagamento = "Debito",
                Valor = 270,
                DataLancamento = Convert.ToDateTime("2019-01-05"),
                IdHistoricos = 1,
                RegistroAtivo = true
            });
            caixas.Add(new Caixa()
            {
                Id = 10,
                Operacao = "Entrada",
                Descricao = "Recebimento serviço",
                Documento = "180-1",
                FormaPagamento = "Debito",
                Valor = 120,
                DataLancamento = Convert.ToDateTime("2019-01-12"),
                IdHistoricos = 1,
                RegistroAtivo = true
            });
            caixas.Add(new Caixa()
            {
                Id = 11,
                Operacao = "Entrada",
                Descricao = "Recebimento serviço",
                Documento = "181-1",
                FormaPagamento = "Debito",
                Valor = 336,
                DataLancamento = Convert.ToDateTime("2019-01-12"),
                IdHistoricos = 1,
                RegistroAtivo = true
            });
            caixas.Add(new Caixa()
            {
                Id = 12,
                Operacao = "Entrada",
                Descricao = "Recebimento serviço",
                Documento = "182-1",
                FormaPagamento = "Debito",
                Valor = 765,
                DataLancamento = Convert.ToDateTime("2019-01-12"),
                IdHistoricos = 1,
                RegistroAtivo = true
            });
            caixas.Add(new Caixa()
            {
                Id = 13,
                Operacao = "Entrada",
                Descricao = "Recebimento serviço",
                Documento = "183-1",
                FormaPagamento = "Debito",
                Valor = 426,
                DataLancamento = Convert.ToDateTime("2019-01-12"),
                IdHistoricos = 1,
                RegistroAtivo = true
            });
            caixas.Add(new Caixa()
            {
                Id = 18,
                Operacao = "Entrada",
                Descricao = "Recebimento serviço",
                Documento = "184-1",
                FormaPagamento = "Debito",
                Valor = 953,
                DataLancamento = Convert.ToDateTime("2019-01-23"),
                IdHistoricos = 1,
                RegistroAtivo = true
            });
            caixas.Add(new Caixa()
            {
                Id = 14,
                Operacao = "Entrada",
                Descricao = "Recebimento serviço",
                Documento = "184-1",
                FormaPagamento = "Debito",
                Valor = 125,
                DataLancamento = Convert.ToDateTime("2019-01-23"),
                IdHistoricos = 1,
                RegistroAtivo = true
            });
            caixas.Add(new Caixa()
            {
                Id = 15,
                Operacao = "Entrada",
                Descricao = "Recebimento serviço",
                Documento = "185-1",
                FormaPagamento = "Debito",
                Valor = 452,
                DataLancamento = Convert.ToDateTime("2019-01-23"),
                IdHistoricos = 1,
                RegistroAtivo = true
            });
            caixas.Add(new Caixa()
            {
                Id = 16,
                Operacao = "Entrada",
                Descricao = "Recebimento serviço",
                Documento = "186-1",
                FormaPagamento = "Debito",
                Valor = 100,
                DataLancamento = Convert.ToDateTime("2019-01-23"),
                IdHistoricos = 1,
                RegistroAtivo = true
            });
            caixas.Add(new Caixa()
            {
                Id = 17,
                Operacao = "Entrada",
                Descricao = "Recebimento serviço",
                Documento = "187-1",
                FormaPagamento = "Debito",
                Valor = 333,
                DataLancamento = Convert.ToDateTime("2019-01-23"),
                IdHistoricos = 1,
                RegistroAtivo = true
            });

            context.Caixas.AddRange(caixas);
            #endregion

            #region categoriaDespesa
            var categoriaDespesa = new List<CategoriaDespesa>();
            categoriaDespesa.Add(new CategoriaDespesa()
            {
                TipoCategoriaDespesa = "Despesa com Funcionário",
                RegistroAtivo = true,
            });
            categoriaDespesa.Add(new CategoriaDespesa()
            {
                TipoCategoriaDespesa = "Despesa com Lanche",
                RegistroAtivo = true,
            });
            context.CategoriasDespesas.AddRange(categoriaDespesa);
            #endregion

            #region categoriaReceita
            var categoriaReceita = new List<CategoriaReceita>();
            categoriaReceita.Add(new CategoriaReceita()
            {
                TipoCategoriaReceita = "Despesa com Paulo",
                RegistroAtivo = true,
            });
            categoriaReceita.Add(new CategoriaReceita()
            {
                TipoCategoriaReceita = "Despesa com Joao",
                RegistroAtivo = true,
            });
            context.CategoriasReceitas.AddRange(categoriaReceita);
            #endregion

            #region clientesPessoasFisicas

            var clientesPessoaFisica = new List<ClientePessoaFisica>();
            clientesPessoaFisica.Add(new ClientePessoaFisica()
            {
                Nome = "Paulo",
                Cpf = "093.455.789-50",
                DataNascimento = Convert.ToDateTime("19/04/2000"),
                LimiteCredito = 190000,
                Email = "paulo.md10@gmail.com",
                Telefone = "991334785",
                Cep = "09456-293",
                Numero = 94,
                Bairro = "Escola Agricola",
                Cidade = "Blumenau",
                Uf = "SC",
                Complemento = "XX",
                RegistroAtivo = true,
            });
            clientesPessoaFisica.Add(new ClientePessoaFisica()
            {
                Nome = "João",
                Cpf = "033.555.119-22",
                DataNascimento = Convert.ToDateTime("09/08/1996"),
                LimiteCredito = -500000,
                Email = "jaoostein@gmail.com",
                Telefone = "994546776",
                Cep = "89031-492",
                Numero = 1152,
                Bairro = "Badenfurt",
                Cidade = "Blumenau",
                Uf = "SC",
                Complemento = "APTO-02",
                RegistroAtivo = true,
            });
            context.ClientesPessoasFisicas.AddRange(clientesPessoaFisica);
            #endregion

            #region clientePessoaJuridica
            var clientesPessoaJuridica = new List<ClientePessoaJuridica>();
            clientesPessoaJuridica.Add(new ClientePessoaJuridica()
            {
                RazaoSocial = "First",
                Atividade = "Sistemas e SoftWares",
                NomeFantasia = "Financial Report System",
                DataCadastro = Convert.ToDateTime("04/09/2019"),
                Cnpj = "83.590.870/0001-95",
                Email = "first@outlook.com",
                Filial = "Hbsis",
                Telefone = "3345-5567",
                Cep = "09432-876",
                Logradouro = "Ubatuba",
                Numero = 675,
                Bairro = "Bairro Vila Olimpia",
                Uf = "SP",
                Cidade = "São Paulo",
                RegistroAtivo = true,

            });

            clientesPessoaJuridica.Add(new ClientePessoaJuridica()
            {
                RazaoSocial = "HBSIS",
                Atividade = "Sistemas e SoftWares",
                NomeFantasia = "HBSIS",
                DataCadastro = Convert.ToDateTime("14/06/2009"),
                Cnpj = "83.590.870/0001-95",
                Email = "HBSIS@gmail.com",
                Filial = "XX",
                Telefone = "3345-5567",
                Cep = "09432-876",
                Logradouro = "XX",
                Numero = 675,
                Bairro = "Bairro Vila Olimpia",
                Uf = "SP",
                Cidade = "São Paulo",
                RegistroAtivo = true,
            });
            context.ClientesPessoasJuridicas.AddRange(clientesPessoaJuridica);
            #endregion

            #region endereços
            var enderecos = new List<Endereco>();
            enderecos.Add(new Endereco()
            {
                Email = "paulo.md10@gmail.com",
                Telefone = "988575072",
                Cep = "89031-492",
                Logradouro = "XX",
                Numero = 88,
                Bairro = "Vila Nova",
                Cidade = "Bluemanu",
                Uf = "SC",
                Complemento = "Bloco-7",
                RegistroAtivo = true

            });

            enderecos.Add(new Endereco()
            {
                Email = "juquinha@hotmail.com",
                Telefone = "987234573",
                Cep = "56432-452",
                Logradouro = "XX",
                Numero = 142,
                Bairro = "itoupava Norte",
                Cidade = "Bluemanu",
                Uf = "SC",
                Complemento = "Rua da Direita",
                RegistroAtivo = true
            });

            #endregion

            #region cadastroscontacorrente
            var cadastroscontacorrente = new List<CadastroContaCorrente>();
            cadastroscontacorrente.Add(new CadastroContaCorrente()
            {

                IdAgencia = 1,
                NumeroConta = 1,
                RegistroAtivo = true,
            });
            cadastroscontacorrente.Add(new CadastroContaCorrente()
            {
                NumeroConta = 1,
                IdAgencia = 1,
                RegistroAtivo = true,
            });
            #endregion

            #region fornecedores
            var fornecedores = new List<Fornecedor>();
            fornecedores.Add(new Fornecedor()
            {
                RazaoSocial = "Peugeot",
                NomeFantasia = "strabourg",
                DataCadastro = Convert.ToDateTime("04/09/2019"),
                Cnpj = "83.590.870/0001-95",
                Email = "first@outlook.com",
                Telefone = "3345-5567",
                Cep = "09432-876",
                Logradouro = "UBATUBA",
                Numero = 675,
                Bairro = "Bairro Vila Olimpia",
                Cidade = "São Paulo",
                Uf = "SP",
                Complemento = "casa",
                RegistroAtivo = true,
            });
            #endregion

            #region historico
            var historico = new List<Historico>();
            historico.Add(new Historico()
            {
                Descricao = "Conta adicionada dia 19/07/2012",
                RegistroAtivo = true
            });
            historico.Add(new Historico()
            {
                Descricao = "Conta paga com sucesso",
                RegistroAtivo = true
            });
            historico.Add(new Historico()
            {
                Descricao = "Conta em atraso, pagar até dia 29/08/1996",
                RegistroAtivo = true
            });
            historico.Add(new Historico()
            {
                Descricao = "Babalu, babala, babalo",
                RegistroAtivo = true
            });
            context.Historicos.AddRange(historico);
            #endregion


            #region funcionario
            var funcionarios = new List<Funcionario>();
            funcionarios.Add(new Funcionario()
            {
                NomeFuncionario = "João Stein",
                TipoFuncionario = "Gerente",
                Usuario = "Joao",
                Senha = "123456",
                RegistroAtivo = true

            });
            funcionarios.Add(new Funcionario()
            {
                NomeFuncionario = "André",
                TipoFuncionario = "Funcionario",
                Usuario = "andrezinho",
                Senha = "123",
                RegistroAtivo = true

            });
            funcionarios.Add(new Funcionario()
            {
                NomeFuncionario = "Paulo",
                TipoFuncionario = "Gerente",
                Usuario = "Paulo",
                Senha = "123",
                RegistroAtivo = true
            });
            funcionarios.Add(new Funcionario()
            {
                NomeFuncionario = "Gustavo",
                TipoFuncionario = "Gerente",
                Usuario = "Gustavo",
                Senha = "123",
                RegistroAtivo = true
            });
            funcionarios.Add(new Funcionario()
            {
                NomeFuncionario = "Paul",
                TipoFuncionario = "Gerente",
                Usuario = "Paul",
                Senha = "123",
                RegistroAtivo = true
            });
            funcionarios.Add(new Funcionario()
            {
                NomeFuncionario = "Cleber",
                TipoFuncionario = "Gerente",
                Usuario = "Cleber",
                Senha = "123",
                RegistroAtivo = true
            });
            context.Funcionarios.AddRange(funcionarios);
            #endregion


            //#endregion

            //    #region fornecedor
            //    var fornecedor = new List<Fornecedor>();
            //    fornecedor.Add(new Fornecedor()
            //    {
            //        RazaoSocial = "Benner",
            //        NomeFantasia = "Paulo",
            //        DataCadastro = Convert.ToDateTime("19/08/2005"),
            //        Cnpj = "93.591.110/0001-56",
            //        RegistroAtivo = true,
            //    });
            //    fornecedor.Add(new Fornecedor()
            //    {
            //        RazaoSocial = "HBSIS",
            //        NomeFantasia = "Francisco",
            //        DataCadastro = Convert.ToDateTime("20/07/2015"),
            //        Cnpj = "39.552.667/0001-32",
            //        RegistroAtivo = true,
            //    });
            //    context.Fornecedores.AddRange(fornecedor);

            //    #endregion






            //#region movimentacaoFinanceiraEntrada
            //var movimentacaoFinanceiraEntrada = new List<MovimentacaoFinanceiraEntrada>();
            //movimentacaoFinanceiraEntrada.Add(new MovimentacaoFinanceiraEntrada()
            //{
            //    Valor = 568,
            //    RegistroAtivo = true
            //});
            //movimentacaoFinanceiraEntrada.Add(new MovimentacaoFinanceiraEntrada()
            //{
            //    Valor = -2422,
            //    RegistroAtivo = true,
            //});
            //movimentacaoFinanceiraEntrada.Add(new MovimentacaoFinanceiraEntrada()
            //{
            //    Valor = 255244,
            //    RegistroAtivo = true,
            //});
            //context.MovimentacaoFinanceiraEntradas.AddRange(movimentacaoFinanceiraEntrada);
            //#endregion

            //#region movimentacaoFinanceiraSaida
            //var movimentacaoFinanceiraSaida = new List<MovimentacaoFinanceiraSaida>();
            //movimentacaoFinanceiraSaida.Add(new MovimentacaoFinanceiraSaida()
            //{
            //    Valor = 77,
            //    RegistroAtivo = true
            //});
            //movimentacaoFinanceiraSaida.Add(new MovimentacaoFinanceiraSaida()
            //{
            //    Valor = -7555,
            //    RegistroAtivo = true
            //});
            //movimentacaoFinanceiraSaida.Add(new MovimentacaoFinanceiraSaida()
            //{
            //    Valor = 72866457,
            //    RegistroAtivo = true
            //});
            //context.MovimentacaoFinanceiraSaidas.AddRange(movimentacaoFinanceiraSaida);
            //#endregion


            //#region parcelaReceber
            //var parcelaReceber = new List<ParcelaReceber>();
            //parcelaReceber.Add(new ParcelaReceber()
            //{
            //    Valor = 12312,
            //    Status = "Vencido",
            //    DataVencimento = Convert.ToDateTime("01/01/2019"),
            //    DataRecebimento = Convert.ToDateTime("02/02/2019"),
            //    RegistroAtivo = true,
            //});
            //parcelaReceber.Add(new ParcelaReceber()
            //{
            //    Valor = 18657328,
            //    Status = "Pago",
            //    DataVencimento = Convert.ToDateTime("13/08/2018"),
            //    DataRecebimento = Convert.ToDateTime("05/08/2018"),
            //    RegistroAtivo = true,
            //});
            //context.ParcelasReceber.AddRange(parcelaReceber);
            //#endregion ParcelaReceber

            #region titulosPagar
            var tituloPagar = new List<TituloPagar>();
            tituloPagar.Add(new TituloPagar()
            {
                IdCategoriaDespesa = 1,
                IdFornecedor = 1,
                Descricao = "Titulo feio por Paulo",
                FormaPagamento = "Dinheiro",
                Caixa = true,
                ValorTotal = 1999,
                Status = "Pago",
                DataLancamento = Convert.ToDateTime("23/06/2016"),
                DataRecebimento = Convert.ToDateTime("22/07/2016"),
                DataVencimento = Convert.ToDateTime("23/07/2016"),
                QuantidadeParcela = 1,
                RegistroAtivo = true

            });
            tituloPagar.Add(new TituloPagar()
            {
                Descricao = "Titulo feio por Paulo",
                FormaPagamento = "Credito",
                Caixa = false,
                ValorTotal = 1,
                Status = "Pendente",
                DataLancamento = Convert.ToDateTime("13/06/2016"),
                DataRecebimento = Convert.ToDateTime("12/07/2019"),
                DataVencimento = Convert.ToDateTime("13/07/2016"),
                QuantidadeParcela = 6,
                RegistroAtivo = true
            });
            #endregion

            #region tituloReceber
            var tituloReceber = new List<TituloReceber>();
            tituloReceber.Add(new TituloReceber()
            {
                Descricao = "Titulo sem compromisso",
                ValorTotal = 125,
                Status = "Pago",
                DataLancamento = Convert.ToDateTime("13/06/2016"),
                DataRecebimento = Convert.ToDateTime("12/07/2019"),
                DataVencimento = Convert.ToDateTime("13/07/2016"),
                QuantidadeParcela = 36,
                RegistroAtivo = true
            });
            tituloReceber.Add(new TituloReceber()
            {
                Descricao = "Titulo com compromisso",
                ValorTotal = 175,
                Status = "Pendente",
                DataLancamento = Convert.ToDateTime("13/06/2016"),
                DataRecebimento = Convert.ToDateTime("12/07/2019"),
                DataVencimento = Convert.ToDateTime("13/07/2016"),
                QuantidadeParcela = 24,
                RegistroAtivo = true
            });
            context.TitulosReceber.AddRange(tituloReceber);
            #endregion

            base.Seed(context);
        }

    }
}