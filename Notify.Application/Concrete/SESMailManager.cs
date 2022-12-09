using Amazon;
using Amazon.Runtime;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using Notify.Application.Abstract;
using Notify.Entity;

namespace Notify.Application.Concrete;


public class SESMailManager : IMailClient
{
    public async Task<SendEmailResponse> SendMail(Email email)
    {
            // Change to your region
            using (var client = new AmazonSimpleEmailServiceClient(RegionEndpoint.EUWest1))
            {
                var sendRequest = new SendEmailRequest
                {
                    Source = email.SenderAddress,
                    Destination = new Destination
                    {
                        ToAddresses =
                        new List<string> { email.ReceiverAddress }
                    },
                    Message = new Message
                    {
                        Subject = new Content(email.Subject),
                        Body = new Body
                        {
                            Html = new Content
                            {
                                Charset = "UTF-8",
                                Data = email.Body
                            },
                            Text = new Content
                            {
                                Charset = "UTF-8",
                                Data = email.Body
                            }
                        }
                    }
                };

                SendEmailResponse result = await client.SendEmailAsync(sendRequest);

                return result;
            }
    }

    public async Task<VerifyEmailIdentityResponse> VerifyEmailAccount(VerifyEmail verifyEmail)
    {
        using (var client = new AmazonSimpleEmailServiceClient(RegionEndpoint.EUWest1))
        {
            var request = new VerifyEmailIdentityRequest(){
                EmailAddress = verifyEmail.MailAddress
            };
            
            VerifyEmailIdentityResponse result = await client.VerifyEmailIdentityAsync(request);
            
            return result;
        }
    }
}