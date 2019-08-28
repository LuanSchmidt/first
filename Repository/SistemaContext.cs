﻿using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SistemaContext : DbContext
    {
        public SistemaContext() : base("SqlServerConnection")
        {

        }
        public DbSet<TituloReceber> TitulosReceber {get;set;}
        public DbSet<MovimentacaoFinanceiraEntrada> movimentacaoFinanceiraEntradas { get; set; }
        public DbSet<CategoriaDespesa> categoriasDespesas { get; set; }
    }
}