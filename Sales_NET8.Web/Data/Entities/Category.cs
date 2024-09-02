﻿using System.ComponentModel.DataAnnotations;

namespace Sales_NET8.Web.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Categorias")]
        [MaxLength(50, ErrorMessage = "O campo {0} tem de ter no máximo {1} caractéres.")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string? Name { get; set; }
    }
}