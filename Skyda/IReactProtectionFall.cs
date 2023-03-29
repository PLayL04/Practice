namespace Skyda
{
    internal interface IReactProtectionFall
    {
        public uint LayerReactorNumber { get; set; }
        public string Message { get; set; }
        public void OnProtectionFall()
        {

        }
    }
}
