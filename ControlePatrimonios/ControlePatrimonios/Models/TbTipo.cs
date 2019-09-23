using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ControlePatrimonios.Models
{
    public partial class TbTipo
    {
        public TbTipo()
        {
            TbItem = new HashSet<TbItem>();
        }

        public int IdTipo { get; set; }
        [Required]
        [Display(Name = "Descrição do Tipo")]
        public string DescricaoTipo { get; set; }

        public ICollection<TbItem> TbItem { get; set; }
    }
}
