using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlePatrimonios.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControlePatrimonios.Controllers
{
    [Authorize]
    public class BlocoController : Controller
    {
        public IActionResult Index()
        {
            return View(GetBlocos());
        }

        private IEnumerable<TbBloco> GetBlocos()
        {
            using (var cont = new ControlePatrimoniosContext())
            {
                return cont.TbBloco.ToList();
            }
        }
    }
}