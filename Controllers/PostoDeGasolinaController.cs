using Microsoft.AspNetCore.Mvc;

namespace PostoDeGasolinaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostoDeGasolinaController : Controller
    {
        [HttpGet("ListaCombustiveis")]
        public IActionResult ListaCombustiveis()
        {
            return StatusCode(200, BancoDeDados.Combustiveis);
        }

        [HttpPost("ComprarCombustivel")]
        public IActionResult ComprarCombustivel(int codigoCombustivel, double litros)
        {
            Combustivel? combustivelEscolhido = null;

            foreach (Combustivel combustivel in BancoDeDados.Combustiveis)
            {
                if (combustivel.CodigoDoProduto == codigoCombustivel)
                {
                    combustivelEscolhido = combustivel;
                    break;
                }
            }

            if (combustivelEscolhido == null)
                return StatusCode(400, "Nenhum código associado foi encontrado");

            Compra compra = new Compra();
            compra.Combustivel = combustivelEscolhido;
            compra.DataCompra = DateTime.Now;
            compra.ValorTotal = combustivelEscolhido.PrecoLitro * litros;

            BancoDeDados.Compras.Add(compra);

            return StatusCode(200, compra);

        }

        [HttpGet("Extrato")]
        public IActionResult Extrato()
        {
            return StatusCode(200, BancoDeDados.Compras);
        }
    }
}
