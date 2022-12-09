using Microsoft.AspNetCore.Mvc;
using Notify.Application.Abstract;
using Notify.Entity;

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

    [HttpPost("/verify-account")]
    public async Task<IActionResult> VerifyEmailAccount(VerifyEmail verifyEmail)
    {
        var result = await _mailClient.VerifyEmailAccount(verifyEmail);

        return StatusCode((int)result.HttpStatusCode, result);
    }

    [HttpPost("/send-mail")]
    public async Task<IActionResult> SendMail(Email email)
    {
        var result = await _mailClient.SendMail(email);

        return StatusCode((int)result.HttpStatusCode, result);
    }
}
