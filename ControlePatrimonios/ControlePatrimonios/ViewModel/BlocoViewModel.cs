using ControlePatrimonios.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlePatrimonios.ViewModel
{
    public class BlocoViewModel
    {

        public int IdBloco { get; set; }
        [Required(ErrorMessage = "Digite o nome do bloco")]
        [Display(Name = "Nome do Bloco")]
        public string NomeBloco { get; set; }

        public TbBloco ConvertToTbBloco(BlocoViewModel blocoVM)
        {
            return new TbBloco
            {
                IdBloco = blocoVM.IdBloco,
                NomeBloco = blocoVM.NomeBloco
            };
        }

        public BlocoViewModel ConvertToBlocoViewModel(TbBloco bloco)
        {
            return new BlocoViewModel
            {
                IdBloco = bloco.IdBloco,
                NomeBloco = bloco.NomeBloco
            };
        }
    }
}
