namespace ImmutableObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationDTO notif = new("Hello", "0939");

            // step3:
            //notif.Message = "Text";
        }
    }

    public class NotificationDTO
    {
        //step 1:
        //private string _message;
        //private string _receiver;

        // step 4: for prevent change internally
        private readonly string _message;
        private readonly string _receiver;  


        public NotificationDTO(string message, string receiver)
        {
            _message = message;
            _receiver = receiver;
        }

        //acccess internal and external
        //public string Message { get; set; }
        //public string Receiver { get; set; }

        // step2: immutable object: not access externally 
        public string Message { get => _message; }
        public string Receiver { get => _receiver; }

        //internally accessible
        //public void Call()
        //{
        //    _message = "ddds";
        //}
    }
}
