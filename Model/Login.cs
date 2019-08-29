﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("logins")]
    public class Login
    {
        [Key,Column("id")]
        public int Id { get; set; }

        [Column("usuario")]
        public string Usuario { get; set; }

        [Column("senha")]
        public string Senha { get; set; }

        [Column("registro_ativo")]
        public bool RegistroAtivo { get; set; }

        #region fk_funcionario
        [Column("id_funcionario")]
        public int IdFuncionario { get; set; }

        [ForeignKey("IdFuncionario")]
        public Funcionario Funcionario { get; set; }
        #endregion
    }

}
