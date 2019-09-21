using System;
using System.Collections.Generic;

namespace ControlePatrimonios.Models
{
    public partial class TbEstado
    {
        public TbEstado()
        {
            TbItem = new HashSet<TbItem>();
        }

        public int IdEstado { get; set; }
        public string DescricaoEstado { get; set; }

        public ICollection<TbItem> TbItem { get; set; }
    }
}
