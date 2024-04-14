using System;

public interface INotificationService
{
    void SendNotification(string message);
}

public class EmailNotificationService : INotificationService
{
    private string emailAddress;

    public EmailNotificationService(string email)
    {
        emailAddress = email;
    }

    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending email to {emailAddress}: {message}");
    }
}

public class WhatsappNotificationService : INotificationService
{
    private string phoneNumber;

    public WhatsappNotificationService(string phone)
    {
        phoneNumber = phone;
    }

    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending WhatsApp message to {phoneNumber}: {message}");
    }
}

public class SmsNotificationService : INotificationService
{
    private string phoneNumber;

    public SmsNotificationService(string phone)
    {
        phoneNumber = phone;
    }

    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending SMS to {phoneNumber}: {message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage of notification services
        EmailNotificationService emailService = new EmailNotificationService("email@example.com");
        emailService.SendNotification("Hello! This is a test message.");

        WhatsappNotificationService whatsappService = new WhatsappNotificationService("+1234567890");
        whatsappService.SendNotification("Hello! This is a test message.");

        SmsNotificationService smsService = new SmsNotificationService("+1234567890");
        smsService.SendNotification("Hello! This is a test message.");
    }
}
