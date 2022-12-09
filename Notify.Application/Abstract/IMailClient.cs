using Amazon.SimpleEmail.Model;
using Notify.Entity;

namespace Notify.Application.Abstract;

public interface IMailClient
{
    public Task<SendEmailResponse> SendMail(Email email);
    public Task<VerifyEmailIdentityResponse> VerifyEmailAccount(VerifyEmail verifyEmail);
}