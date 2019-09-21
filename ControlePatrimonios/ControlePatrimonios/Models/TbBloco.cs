using System;
using System.Collections.Generic;

namespace ControlePatrimonios.Models
{
    public partial class TbBloco
    {
        public TbBloco()
        {
            TbSetor = new HashSet<TbSetor>();
        }

        public int IdBloco { get; set; }
        public string NomeBloco { get; set; }

        public ICollection<TbSetor> TbSetor { get; set; }
    }
}
