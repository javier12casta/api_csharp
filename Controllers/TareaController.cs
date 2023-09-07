using Microsoft.AspNetCore.Mvc;
using api_csharp.Models;

using api_csharp.Services;

namespace api_csharp.Controllers;

[Route("api/[controller]")]
public class TareaController : ControllerBase
{
    ITareasService tareasService;

    public TareaController(ITareasService service)
    {
        tareasService = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(tareasService.Get());
    }
}