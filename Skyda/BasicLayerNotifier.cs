namespace Skyda
{
    internal class BasicLayerNotifier : IReactProtectionFall
    {
        public uint LayerReactorNumber { get; set; }
        public void OnProtectionFall();
    }
}
