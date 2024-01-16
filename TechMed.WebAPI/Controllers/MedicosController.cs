using System.Collections;
using Microsoft.AspNetCore.Mvc;


namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MedicosController : ControllerBase
{
    private static readonly string[] MedicList = new[]
{
        "Joao", "Henrique", "Pedro", "Lucas", "Marina", "Mario", "Welvis", "Giuseppe", "Eduardo", "Matheus"
    };

    private readonly ILogger<MedicosController> _logger;

    public MedicosController(ILogger<MedicosController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetMedico")]

    public IEnumerable<Medico> Get()
    {
        List<Medico> medicos = new List<Medico>();
        return Enumerable.Range(1, 5).Select(index => new Medico
        {
            Nome = MedicList[Random.Shared.Next(MedicList.Length)],

            CRM = Random.Shared.Next(1, 1000)


        })
        .ToArray();

    }

    [HttpDelete(Name = "DeleteMedico")]

    public IActionResult Delete()
    {


        return Ok("deletado");
    }

    [HttpPost(Name = "PostMedico")]
    public IActionResult Post()
    {

        return Ok("postado");
    }

    [HttpPut(Name = "PutMedico")]
    public IActionResult Put()
    {
        return Ok("atualizado");
    }

}
