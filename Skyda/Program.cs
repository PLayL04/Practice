namespace Skyda
{
    internal class Program
    {
        delegate void ProtectionFallHendler(ProtectionFallEventArgs);
        event ProtectionFallHendler? Message;
        static void Main(string[] args)
        {

        }
    }
}