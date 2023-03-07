using System;

namespace MiniMilestone
{
    public class SmartLight : Device
    {
        public enum SmartLightTypes
        {
            LedStreetLights,
            HalogenStreetLights
        }
        public SmartLightTypes Type { get;set; }


        public string _Power;

        public string Power
        {
            get => _Power;
            set
            {
                switch (Type)
                {
                    case SmartLightTypes.HalogenStreetLights:
                        _Power = "200";
                        break;
                    case SmartLightTypes.LedStreetLights:
                        _Power = "150";
                        break;
                }
            }
        }
        public struct MyStruct(Type myType)
        {

        }
}
}