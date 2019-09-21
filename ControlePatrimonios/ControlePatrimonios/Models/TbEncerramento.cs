using System;
using System.Collections.Generic;

namespace ControlePatrimonios.Models
{
    public partial class TbEncerramento
    {
        public int IdEncerramento { get; set; }
        public int IdItem { get; set; }
        public DateTime DataEncerramento { get; set; }
        public string Motivo { get; set; }

        public TbItem IdItemNavigation { get; set; }
    }
}
