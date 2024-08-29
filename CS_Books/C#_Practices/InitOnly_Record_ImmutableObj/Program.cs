namespace InitOnly_Record_ImmutableObj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //we dont have ctor now! if we had we can initialize them in the time of Instanciate
            //NotificationDTO notif = new("Hello", "0939");

            NotificationDTO notif = new()
            {
                Message = "hello"
                // cant change after initialization
            };
        }
    }

    public class NotificationDTO
    {

        // ctor for initializing the objects
        //public NotificationDTO(string message, string receiver)
        //{
        //    Message = message;
        //    Receiver = receiver;
        //}

        public string Message { get; init; }
        public string Receiver { get; init; }
    }
}
