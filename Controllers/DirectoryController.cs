using Microsoft.AspNetCore.Mvc;
using TrainingDirectory.Api.Services;

namespace TrainingDirectory.Api.Controller;

[ApiController]
[Route("api/directory")]
public class DirectoryController: ControllerBase
{
    private readonly IDirectoryService _service;

    public DirectoryController(IDirectoryService service)
    {
        _service = service;
    }

    [HttpGet("/trainee/{traineeId}")]
    public async Task<IActionResult> GetProfile(long traineeId)
    {
        var profile =  await _service.GetProfileAsync(traineeId);
        if(profile == null)
        {
            return NotFound();
        }

        return Ok(profile);
    }
}