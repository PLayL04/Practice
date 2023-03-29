namespace Skyda
{
    internal class Skyda
    {
        public uint KnownFalledProtectionLayerNumber { get; set; }
        public virtual void Attack(ProtectionSystem pS)
        {
            if (pS.GetAttak() == true)
            {
                this.KnownFalledProtectionLayerNumber += 1;
            }
        }
        public virtual void NotifyProtectionFall(ProtectionSystem pS)
        {
                
        }
    }
}
