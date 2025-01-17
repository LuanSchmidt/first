using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Repository
{
    internal class SistemaInitializer : CreateDatabaseIfNotExists<SistemaContext>
    //internal class SistemaInitializer : DropCreateDatabaseAlways<SistemaContext>
    {
        protected override void Seed(SistemaContext context)
        {
            #region agencias
            var agencias = new List<Agencia>();
            agencias.Add(new Agencia()
            {
                Id = 1,
                NomeAgencia = "Agencia da Vida",
                NumeroAgencia = 2001,
                Banco = "Banco de Vida",
                RegistroAtivo = true
            });
            agencias.Add(new Agencia()
            {
                Id = 2,
                NomeAgencia = "Agencia do Paulo",
                NumeroAgencia = 666,
                Banco = "Banco do Paulo",
                RegistroAtivo = true
            });

            agencias.Add(new Agencia()
            {
                Id = 3,
                NomeAgencia = "Voc� consegue",
                NumeroAgencia = 8001,
                Banco = "Banco do Goku",
                RegistroAtivo = true,
            });
            context.Agencias.AddRange(agencias);

            #endregion

            #region caixa


            var caixas = new List<Caixa>();
            caixas.Add(new Caixa()
            {
                Id = 1,
                Descricao = "recebimento servi�o",
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
                Descricao = "Recebimento servi�o",
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
                Descricao = "Recebimento servi�o",
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
                Descricao = "Recebimento servi�o",
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
                Descricao = "Recebimento servi�o",
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
                Descricao = "Recebimento servi�o",
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
                Descricao = "Recebimento servi�o",
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
                Descricao = "Recebimento servi�o",
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
                Descricao = "Recebimento servi�o",
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
                Descricao = "Recebimento servi�o",
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
                Descricao = "Recebimento servi�o",
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
                Descricao = "Recebimento servi�o",
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
                Descricao = "Recebimento servi�o",
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
                Descricao = "Recebimento servi�o",
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
                Descricao = "Recebimento servi�o",
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
                Descricao = "Recebimento servi�o",
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
                Descricao = "Recebimento servi�o",
                Documento = "187-1",
                FormaPagamento = "Debito",
                Valor = 333,
                DataLancamento = Convert.ToDateTime("2019-01-23"),
                IdHistoricos = 1,
                RegistroAtivo = true
            });

            context.Caixas.AddRange(caixas);
            #endregion

            #region Transa��o
            var transacao = new List<Transacao>();
            transacao.Add(new Transacao()
            {
                Id = 1,
                DescricaoTransacao = "Recebimento de venda de produto",
                Documento = "1-2",
                TipoPagamento = "Dinheiro",
                Valor = 100,
                DataLancamento = Convert.ToDateTime("2019-01-02"),
                DataRecebimento = Convert.ToDateTime("2019-01-02"),
                IdCadastrosContaCorrente = 1,
                IdCategoriaDespesa = 1,
                IdCategoriaReceita = 1,
                IdHistorico = 1,
                RegistroAtivo = true,
            });
            transacao.Add(new Transacao()
            {
                Id = 2,
                DescricaoTransacao = "Recebimento de venda de produto",
                Documento = "1-2",
                TipoPagamento = "Dinheiro",
                Valor = 101,
                DataLancamento = Convert.ToDateTime("2019-01-02"),
                DataRecebimento = Convert.ToDateTime("2019-01-02"),
                IdCadastrosContaCorrente = 1,
                IdCategoriaDespesa = 1,
                IdCategoriaReceita = 1,
                IdHistorico = 1,
                RegistroAtivo = true,
            });
            transacao.Add(new Transacao()
            {
                Id = 3,
                DescricaoTransacao = "Recebimento de venda de produto",
                Documento = "3-2",
                TipoPagamento = "Dinheiro",
                Valor = 300,
                DataLancamento = Convert.ToDateTime("2019-01-05"),
                DataRecebimento = Convert.ToDateTime("2019-01-05"),
                IdCadastrosContaCorrente = 1,
                IdCategoriaDespesa = 1,
                IdCategoriaReceita = 1,
                IdHistorico = 1,
                RegistroAtivo = true,
            });
            transacao.Add(new Transacao()
            {
                Id = 4,
                DescricaoTransacao = "Recebimento de venda de produto",
                Documento = "4-2",
                TipoPagamento = "Dinheiro",
                Valor = 150,
                DataLancamento = Convert.ToDateTime("2019-01-05"),
                DataRecebimento = Convert.ToDateTime("2019-01-05"),
                IdCadastrosContaCorrente = 1,
                IdCategoriaDespesa = 1,
                IdCategoriaReceita = 1,
                IdHistorico = 1,
                RegistroAtivo = true,
            });
            transacao.Add(new Transacao()
            {
                Id = 5,
                DescricaoTransacao = "Recebimento de venda de produto",
                Documento = "5-2",
                TipoPagamento = "Dinheiro",
                Valor = 1545,
                DataLancamento = Convert.ToDateTime("2019-01-05"),
                DataRecebimento = Convert.ToDateTime("2019-01-05"),
                IdCadastrosContaCorrente = 1,
                IdCategoriaDespesa = 1,
                IdCategoriaReceita = 1,
                IdHistorico = 1,
                RegistroAtivo = true,
            }); transacao.Add(new Transacao()
            {
                Id = 6,
                DescricaoTransacao = "Recebimento de venda de produto",
                Documento = "1-2",
                TipoPagamento = "Dinheiro",
                Valor = 515,
                DataLancamento = Convert.ToDateTime("2019-01-10"),
                DataRecebimento = Convert.ToDateTime("2019-01-10"),
                IdCadastrosContaCorrente = 1,
                IdCategoriaDespesa = 1,
                IdCategoriaReceita = 1,
                IdHistorico = 1,
                RegistroAtivo = true,
            });
            transacao.Add(new Transacao()
            {
                Id = 7,
                DescricaoTransacao = "Recebimento de venda de produto",
                Documento = "7-2",
                TipoPagamento = "Dinheiro",
                Valor = 750,
                DataLancamento = Convert.ToDateTime("2019-01-10"),
                DataRecebimento = Convert.ToDateTime("2019-01-10"),
                IdCadastrosContaCorrente = 1,
                IdCategoriaDespesa = 1,
                IdCategoriaReceita = 1,
                IdHistorico = 1,
                RegistroAtivo = true,
            });
            context.Transacoes.AddRange(transacao);


            #endregion

            #region categoriaDespesa
            var categoriaDespesa = new List<CategoriaDespesa>();
            categoriaDespesa.Add(new CategoriaDespesa()
            {
                Id = 1,
                TipoCategoriaDespesa = "Despesa com Funcion�rio",
                RegistroAtivo = true,
            });
            categoriaDespesa.Add(new CategoriaDespesa()
            {
                Id = 2,
                TipoCategoriaDespesa = "Despesa com Manuten��o",
                RegistroAtivo = true,
            });
            context.CategoriasDespesas.AddRange(categoriaDespesa);
            #endregion

            #region categoriaReceita
            var categoriaReceita = new List<CategoriaReceita>();
            categoriaReceita.Add(new CategoriaReceita()
            {
                Id = 1,
                TipoCategoriaReceita = "Despesa com Paulo",
                RegistroAtivo = true,
            });
            categoriaReceita.Add(new CategoriaReceita()
            {
                Id = 2,
                TipoCategoriaReceita = "Despesa com Joao",
                RegistroAtivo = true,
            });
            context.CategoriasReceitas.AddRange(categoriaReceita);
            #endregion

            #region clientes pessoa fisica
            var clientesPessoaFisica = new List<ClientePessoaFisica>();
            clientesPessoaFisica.Add(new ClientePessoaFisica()
            {
                Id = 1,
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
                Id = 2,
                Nome = "Jo�o",
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
                Id = 1,
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
                Cidade = "S�o Paulo",
                RegistroAtivo = true,

            });

            clientesPessoaJuridica.Add(new ClientePessoaJuridica()
            {
                Id = 2,
                RazaoSocial = "FG",
                Atividade = "Constru��o Civil",
                NomeFantasia = "FG",
                DataCadastro = Convert.ToDateTime("14/06/2009"),
                Cnpj = "83.590.870/0001-95",
                Email = "FG@gmail.com",
                Filial = "XX",
                Telefone = "3345-5567",
                Cep = "09432-876",
                Logradouro = "XX",
                Numero = 675,
                Bairro = "Bairro Vila Olimpia",
                Uf = "SP",
                Cidade = "S�o Paulo",
                RegistroAtivo = true,
            });
            context.ClientesPessoasJuridicas.AddRange(clientesPessoaJuridica);
            #endregion

            #region tituloPagar
            var tituloPagar = new List<TituloPagar>() {
                new TituloPagar()
                {
                    Id = 1,
                    Descricao = "Titulo a pagar",
                    FormaPagamento = "Cart�o de Cr�dito",
                    Caixa = true,
                    ValorTotal = 2000,
                    Status = "Pendente",
                    DataLancamento = DateTime.Now,
                    DataVencimento = DateTime.Now,
                    QuantidadeParcela = 4,
                    RegistroAtivo = true,
                    IdCategoriaDespesa = 1,
                    IdFornecedor = 1
                },
                new TituloPagar()
                {
                    Id = 2,
                    Descricao = "Titulo a pagar",
                    FormaPagamento = "Dinheiro",
                    Caixa = true,
                    ValorTotal = 198,
                    Status = "Pendente",
                    DataLancamento = DateTime.Now,
                    DataVencimento = DateTime.Now,
                    QuantidadeParcela = 5,
                    RegistroAtivo = true,
                    IdCategoriaDespesa = 1,
                    IdFornecedor = 1
                }
            };
            context.TitulosPagar.AddRange(tituloPagar);
            #endregion

            #region cadastrocontacorrente
            var cadastroscontacorrente = new List<CadastroContaCorrente>() {
                new CadastroContaCorrente()
                {
                    Id = 1,
                    NumeroConta = 80,
                    IdAgencia = 1,
                    RegistroAtivo = true,
                },

                  new CadastroContaCorrente()
                  {
                      Id = 2,
                      NumeroConta = 1000,
                      IdAgencia = 2,
                      RegistroAtivo = true,
                  },
                  new CadastroContaCorrente()
                  {
                      Id = 3,
                      NumeroConta = 1000,
                      IdAgencia = 1,
                      RegistroAtivo = true,
                  }
            };
            context.CadastroContaCorrentes.AddRange(cadastroscontacorrente);

            #endregion

            #region fornecedores
            var fornecedores = new List<Fornecedor>()
            {
                new Fornecedor()
                {
                Id = 1,
                RazaoSocial = "Peugeot",
                NomeFantasia = "strabourg",
                DataCadastro = DateTime.Now,
                Cnpj = "83.590.870/0001-95",
                Email = "first@outlook.com",
                Telefone = "3345-5567",
                Cep = "09432-876",
                Logradouro = "UBATUBA",
                Numero = 675,
                Bairro = "Bairro Vila Olimpia",
                Cidade = "S�o Paulo",
                Uf = "SP",
                Complemento = "casa",
                RegistroAtivo = true
                },
                new Fornecedor()
                {
                Id = 2,
                RazaoSocial = "Honda",
                NomeFantasia = "Honda",
                DataCadastro = DateTime.Now,
                Cnpj = "83.590.870/0001-95",
                Email = "first@outlook.com",
                Telefone = "3345-5567",
                Cep = "09432-876",
                Logradouro = "UBATUBA",
                Numero = 675,
                Bairro = "Bairro Vila Olimpia",
                Cidade = "S�o Paulo",
                Uf = "SP",
                Complemento = "casa",
                RegistroAtivo = true
                }
            };
            context.Fornecedores.AddRange(fornecedores);
            #endregion

            #region historico
            var historico = new List<Historico>();
            historico.Add(new Historico()
            {
                Id = 1,
                Descricao = "Conta adicionada dia 19/07/2000",
                RegistroAtivo = true
            });
            historico.Add(new Historico()
            {
                Id = 2,
                Descricao = "Conta paga com sucesso",
                RegistroAtivo = true
            });
            historico.Add(new Historico()
            {
                Id = 3,
                Descricao = "Conta em atraso, pagar at� dia 29/08/1996",
                RegistroAtivo = true
            });
            context.Historicos.AddRange(historico);
            #endregion

            #region parcelaPagar
            var parcelaPagar = new List<ParcelaPagar>();
            parcelaPagar.Add(new ParcelaPagar()
            {
                Id = 1,
                Valor = 2333,
                Status = "Pago",
                DataVencimento = Convert.ToDateTime("17/02/2019"),
                DataPagamento = Convert.ToDateTime("17/02/2019"),
                RegistroAtivo = true
            });
            parcelaPagar.Add(new ParcelaPagar()
            {
                Id = 2,
                Valor = 9523,
                Status = "Pendente",
                DataVencimento = Convert.ToDateTime("04/09/2019"),
                DataPagamento = Convert.ToDateTime("05/09/2019"),
                RegistroAtivo = true
            });
            context.ParcelasPagar.AddRange(parcelaPagar);
            #endregion

            #region funcionario
            var funcionarios = new List<Funcionario>();
            funcionarios.Add(new Funcionario()
            {
                Id = 1,
                NomeFuncionario = "Jo�o Stein",
                TipoFuncionario = "Gerente",
                Usuario = "Joao",
                Senha = "sembraco",
                RegistroAtivo = true

            });
            funcionarios.Add(new Funcionario()
            {
                Id = 2,
                NomeFuncionario = "Andr�",
                TipoFuncionario = "Funcionario",
                Usuario = "andrezinho",
                Senha = "123",
                RegistroAtivo = true

            });
            funcionarios.Add(new Funcionario()
            {
                Id = 3,
                NomeFuncionario = "Paulo",
                TipoFuncionario = "Gerente",
                Usuario = "Paulo",
                Senha = "123",
                RegistroAtivo = true
            });
            funcionarios.Add(new Funcionario()
            {
                Id = 3,
                NomeFuncionario = "Gustavo",
                TipoFuncionario = "Gerente",
                Usuario = "Gustavo",
                Senha = "123",
                RegistroAtivo = true
            });
            funcionarios.Add(new Funcionario()
            {
                Id = 4,
                NomeFuncionario = "Paul",
                TipoFuncionario = "Gerente",
                Usuario = "Paul",
                Senha = "123",
                RegistroAtivo = true
            });
            funcionarios.Add(new Funcionario()
            {
                Id = 5,
                NomeFuncionario = "Cleber",
                TipoFuncionario = "Gerente",
                Usuario = "Cleber",
                Senha = "123",
                RegistroAtivo = true
            });
            context.Funcionarios.AddRange(funcionarios);
            #endregion

            #region tituloReceber
            var tituloReceber = new List<TituloReceber>() {
                new TituloReceber()
                {
                    Id = 1,
                    IdClientePessoaFisica = 1,
                    IdCategoriaReceita = 1,
                    Status = "Pago",
                    DataLancamento = DateTime.Now,
                    DataRecebimento = Convert.ToDateTime("22/07/2016"),
                    DataVencimento = Convert.ToDateTime("23/07/2016"),
                    ValorTotal = 1999,
                    QuantidadeParcela = 1,
                    Descricao = "Titulo feio por Paulo",

                    RegistroAtivo = true,
                }

            };
            context.TitulosReceber.AddRange(tituloReceber);
            #endregion

            base.Seed(context);
        }

    }
}
