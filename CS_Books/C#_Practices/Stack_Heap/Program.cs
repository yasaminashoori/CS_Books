namespace Stack_Heap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 15;
            string s = "Hello";
            InfoValueType info = new();
            info.Name = "YASAMIN";
            InfoReferenceType infoRef = new();
            infoRef.Name = "ASHOORI";
            List<InfoReferenceType> infoList = new();
            infoList[5].Name = "LIST OF INFO";   
        }
    }

    internal struct InfoValueType
    {
        public int Id;
        public double Value;
        public DateTime BirthDay;
        public string Name;   
    }

    // custom types: compiler diesnt know them 
    internal class InfoReferenceType
    {
        public int Id;
        public double Value;
        public DateTime BirthDay;
        public string Name;
    }
}
