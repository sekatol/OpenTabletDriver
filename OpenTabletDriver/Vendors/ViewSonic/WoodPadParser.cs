using OpenTabletDriver.Plugin.Tablet;
using OpenTabletDriver.Tablet;

namespace OpenTabletDriver.Vendors.ViewSonic
{
    public class WoodPadReportParser : IReportParser<IDeviceReport>
    {
        public IDeviceReport Parse(byte[] report)
        {
            if ((report[9] & 0b11) == 0b11)
                return new WoodPadReport(report);

            return new DeviceReport(report);
        }
    }
}