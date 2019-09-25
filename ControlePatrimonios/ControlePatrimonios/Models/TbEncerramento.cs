using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ControlePatrimonios.Models
{
    public partial class TbEncerramento
    {
        public int IdEncerramento { get; set; }
        [Required]
        public int IdItem { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataEncerramento { get; set; }
        [Required]
        public string Motivo { get; set; }
        [Required]
        [Display(Name = "Nome do Item")]
        public TbItem IdItemNavigation { get; set; }
    }
}
