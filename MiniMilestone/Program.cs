using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMilestone
{
    public class Program
    {
        static void Main(string[] args)
        {
            SmartLight smartLight = new SmartLight();
            smartLight.Type = SmartLight.SmartLightTypes.LedStreetLights;
            smartLight.Name = "Company1";
            smartLight.Manufacturer = "Manufacturer1";
            Console.WriteLine(smartLight.Power);

            smartLight.Power = "150";
            Console.WriteLine(smartLight.Power);

            Console.ReadLine();
        }
    }
}
