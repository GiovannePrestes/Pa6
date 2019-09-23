using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ControlePatrimonios.Models
{
    public partial class TbEstado
    {
        public TbEstado()
        {
            TbItem = new HashSet<TbItem>();
        }

        public int IdEstado { get; set; }
        [Required]
        [Display(Name = "Descrição do Estado")]
        public string DescricaoEstado { get; set; }

        public ICollection<TbItem> TbItem { get; set; }
    }
}
