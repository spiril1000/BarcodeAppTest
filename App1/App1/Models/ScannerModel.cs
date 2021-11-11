using ZebraBarcodeScannerSDK;

namespace BarcodeSannerApp.Model
{
    /// <summary>
    /// Scanner Model
    /// </summary>
    public class ScannerModel
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string ModeType { get; set; }
        public Scanner ScannerObject { get; set; }
        public string ConnectionStatus { get; set; }
    }
}