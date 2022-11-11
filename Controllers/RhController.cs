using Microsoft.AspNetCore.Mvc;

namespace RH_ANALISE_CV_API.Controllers;

[ApiController]
[Route("[controller]")]
public class RhController : ControllerBase
{

    private readonly ILogger<RhController> _logger;

    public RhController(ILogger<RhController> logger)
    {
        _logger = logger;
    }

    [HttpPost("incluir-documento")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public ActionResult EnviaArquivo([FromForm] Curriculo curriculo)
    {
        if(curriculo == null){
            return BadRequest();
        }
        
        return Ok();
    }
}
