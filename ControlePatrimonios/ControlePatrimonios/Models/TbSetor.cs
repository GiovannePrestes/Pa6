using System;
using System.Collections.Generic;

namespace ControlePatrimonios.Models
{
    public partial class TbSetor
    {
        public TbSetor()
        {
            TbItem = new HashSet<TbItem>();
        }

        public int IdSetor { get; set; }
        public string NomeSetor { get; set; }
        public int IdBloco { get; set; }

        public TbBloco IdBlocoNavigation { get; set; }
        public ICollection<TbItem> TbItem { get; set; }
    }
}
