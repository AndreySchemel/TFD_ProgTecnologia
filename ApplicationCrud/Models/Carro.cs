using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApplicationCrud.Models
{
    public class Carro
    {

        public int Id { get; set; }

        public string Cor { get; set; }

        [Required]
        public string Placa { get; set; }

        [Required]
        [StringLength(255)]
        public string Marca { get; set; }

        [Required]
        [StringLength(255)]
        public string Modelo { get; set; }

        [Required]
        public double ValorLocacao { get; set;}

    }
}