using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ControlePatrimonios.Models
{
    public partial class TbItem
    {
        public TbItem()
        {
            TbEncerramento = new HashSet<TbEncerramento>();
        }
        public int IdItem { get; set; }
        [Required]
        public int IdSetor { get; set; }
        [Required]
        public int IdTipo { get; set; }
        [Required]
        public int IdEstado { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:000000}")]
        public decimal Patrimonio { get; set; }
        [Required]
        public string ServiceTag { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataCriacao { get; set; }
        public string NomeItem { get { return String.Format(this.Patrimonio.ToString() + " - " + this.Descricao); } }
        [Display(Name = "Estado")]
        public TbEstado IdEstadoNavigation { get; set; }
        [Display(Name = "Setor")]
        public TbSetor IdSetorNavigation { get; set; }
        [Display(Name = "Tipo")]
        public TbTipo IdTipoNavigation { get; set; }
        public ICollection<TbEncerramento> TbEncerramento { get; set; }
    }
}
