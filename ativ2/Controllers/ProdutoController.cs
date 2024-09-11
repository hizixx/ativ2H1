using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProdutoController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateProduto([FromBody] Produto produto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }


        return Ok(produto);
    }
}
    