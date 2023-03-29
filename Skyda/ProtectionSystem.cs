namespace Skyda
{
    internal class ProtectionSystem
    {
        public string Title { get; set; }
        public DateTime Date
        {
            get
            {
                return this.Date;
            }
            set
            {
                Date = DateTime.Today;
            }
        }
        public uint ProtectionLayerNumber { get; set; }
        public uint FalledProtectionLayerNumber { get; set; }
        public virtual uint ProtectionCheck()
        {
            this.Date = Date.AddDays(1);
            return this.ProtectionLayerNumber;
        }
        public virtual bool GetAttak()
        {
            Random rnd = new Random();
            int chance = 10;
            if (rnd.Next(0, chance) == 1)
            {
                this.ProtectionLayerNumber -= 1;
                this.FalledProtectionLayerNumber += 1;
                return true;
            }
            else return false;
        }
    }
}
