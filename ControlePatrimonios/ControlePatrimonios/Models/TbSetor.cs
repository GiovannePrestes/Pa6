using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ControlePatrimonios.Models
{
    public partial class TbSetor
    {
        public TbSetor()
        {
            TbItem = new HashSet<TbItem>();
        }
        
        public int IdSetor { get; set; }
        [Required]
        [Display(Name = "Nome do Setor")]
        public string NomeSetor { get; set; }
        [Required]
        public int IdBloco { get; set; }

        [Required]
        [Display(Name = "Nome do Bloco")]
        public TbBloco IdBlocoNavigation { get; set; }
        public ICollection<TbItem> TbItem { get; set; }
    }
}
