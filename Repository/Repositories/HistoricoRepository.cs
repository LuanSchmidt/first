﻿using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class HistoricoRepository : IHistoricoRepository
    {
        private SistemaContext context;

        public HistoricoRepository()
        {
            context = new SistemaContext();
        }


        public bool Alterar(Historico historico)
        {
            throw new NotImplementedException();
        }

        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public int Inserir(Historico historico)
        {
            throw new NotImplementedException();
        }

        public Historico ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Historico> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
