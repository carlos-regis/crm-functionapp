using System;

namespace SharedLibraries_Plugins.Models
{
    public partial class ApplianceResponse
    {
        public Equipment[] Equipment { get; set; }
    }

    public partial class Equipment
    {
        public string SerialNumber { get; set; }

        public string Brand { get; set; }

        public string TtNr { get; set; }

        public DateTime ManufacturingDate { get; set; }

        public string ProductionPlant { get; set; }

        public string ProductionCounter { get; set; }

        public string RawSerialNumber { get; set; }
    }
}