namespace Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationDTO notif = new("Hello", "0939");
            NotificationDTO notif2 = notif with { Message = "Text" };
        }
    }

    public record NotificationDTO(string Message, string Receiver);
}
