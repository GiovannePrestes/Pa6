using System;
using System.Collections.Generic;

namespace ControlePatrimonios.Models
{
    public partial class TbTipo
    {
        public TbTipo()
        {
            TbItem = new HashSet<TbItem>();
        }

        public int IdTipo { get; set; }
        public string DescricaoTipo { get; set; }

        public ICollection<TbItem> TbItem { get; set; }
    }
}
