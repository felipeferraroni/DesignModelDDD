﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DesignModelDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150,ErrorMessage = "Máximo {0} de Caracteres")]
        [MinLength(2,ErrorMessage = "Mínimo {0} de Caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} de Caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} de Caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} de Caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um e-mail Válido")]
        [DisplayName("E-Mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}
