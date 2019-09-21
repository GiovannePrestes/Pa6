using System;
using System.Collections.Generic;

namespace ControlePatrimonios.Models
{
    public partial class TbItem
    {
        public TbItem()
        {
            TbEncerramento = new HashSet<TbEncerramento>();
        }

        public int IdItem { get; set; }
        public int IdSetor { get; set; }
        public int IdTipo { get; set; }
        public int IdEstado { get; set; }
        public decimal Patrimonio { get; set; }
        public string ServiceTag { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }

        public TbEstado IdEstadoNavigation { get; set; }
        public TbSetor IdSetorNavigation { get; set; }
        public TbTipo IdTipoNavigation { get; set; }
        public ICollection<TbEncerramento> TbEncerramento { get; set; }
    }
}
