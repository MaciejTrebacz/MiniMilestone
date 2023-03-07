using System.Collections.Generic;

namespace MiniMilestone
{
    public class Gateaway
    {
        public string Manufacturer { get; set; }
        public string Address { get; set; }
        public List<Device> Devices { get; set; }
    }
}