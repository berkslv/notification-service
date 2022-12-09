using Notify.Application.Abstract;

namespace Notify.Application.Concrete;


public class SESMailManager : IMailClient
{
    public void SendMail()
    {
        Console.WriteLine("SEND MAİL!");
    }
}