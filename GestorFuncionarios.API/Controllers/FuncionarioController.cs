using GestorFuncionarios.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestorFuncionarios.API.Controllers
{
    public class FuncionarioController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("oi");
        }
    }
}
