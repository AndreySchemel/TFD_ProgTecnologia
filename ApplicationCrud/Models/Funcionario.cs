﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApplicationCrud.Models
{
    public class Funcionario
    {

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Nome { get; set; }

        public string Cargo { get; set; }

        [Required]
        public long Telefone { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        public int Matricula { get; set; }

    }
}