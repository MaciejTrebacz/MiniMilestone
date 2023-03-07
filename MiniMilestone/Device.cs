namespace MiniMilestone
{
    public abstract class Device
    {
        public string Manufacturer { get; set; } 
        public string Name { get; set; }
        public long SerialNumber { get; set; }
        public int Warranty { get; set; }

        public _ConnectionStatus ConnectionStatus { get; set; }

        public enum _ConnectionStatus
        {
            connected,
            warning,
            error
        }


    }
}