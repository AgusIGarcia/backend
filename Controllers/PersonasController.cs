using Microsoft.AspNetCore.Mvc;
using backend.Domain;
using backend.Services;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonasController : ControllerBase
{

    private readonly PersonaService _ips;
    public PersonasController(PersonaService ips)
    {
        _ips = ips;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(this._ips.GetAllPersonas());
    }

    [HttpGet(("{id:int}"))]
    public IActionResult Get(int id)
    {
        return Ok(this._ips.GetPersona(id));
    }

    [HttpPost]
    public IActionResult Create(Persona p)
    {
        this._ips.CreatePersona(p);
        return Ok();
    }
}