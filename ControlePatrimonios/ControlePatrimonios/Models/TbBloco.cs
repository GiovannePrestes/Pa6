using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ControlePatrimonios.Models
{
    public partial class TbBloco
    {
        public TbBloco()
        {
            TbSetor = new HashSet<TbSetor>();
        }
        public int IdBloco { get; set; }
        [Required(ErrorMessage = "Digite o nome do bloco")]
        [Display(Name = "Nome do Bloco")]
        [StringLength(1, ErrorMessage ="Quantidade máxima de caracteres é 1")]
        public string NomeBloco { get; set; }

        public ICollection<TbSetor> TbSetor { get; set; }
    }
}
