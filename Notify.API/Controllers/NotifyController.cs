using Microsoft.AspNetCore.Mvc;
using Notify.Application.Abstract;

namespace Notify.API.Controllers;

[ApiController]
[Route("")]
public class NotifyController : ControllerBase
{
    private readonly ILogger<NotifyController> _logger;
    private readonly IMailClient _mailClient;

    public NotifyController(ILogger<NotifyController> logger, IMailClient mailClient)
    {
        _logger = logger;
        _mailClient = mailClient;
    }

    [HttpGet("/send-mail")]
    public IActionResult Get()
    {
        _mailClient.SendMail();

        return Ok("Hello world!");
    }
}
