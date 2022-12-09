namespace Notify.Entity;

public class Email
{
    public string SenderAddress { get; set; }
    public string ReceiverAddress { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
}