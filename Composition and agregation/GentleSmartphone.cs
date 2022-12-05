namespace Composition_and_agregation
{
    public class GentleSmartphone
    {
        int SmartphoneID { get; set; }
        public TactileSensor Sensor;
        public GentleSmartphone()
        {
            Sensor = new TactileSensor();
        }
    }
}
