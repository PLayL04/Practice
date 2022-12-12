namespace comp
{
    public class GentleSmartphone
    {
        public int SerialNumber { get; set; }
        public TactileSensor Sensor;
        public GentleSmartphone()
        {
            Sensor = new TactileSensor();
        }
    }
}
