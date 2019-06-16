using System;

namespace Generate.PDF.Business.Interfaces
{
    public interface ICustomer
    {
        short Building { get; set; }

        string SerialNumber { get; set; }

        string HouseUnitNo { get; set; }

        string Street { get; set; }

        string Suburb { get; set; }

        string Postcode { get; set; }

        string NearestStreet { get; set; }

        string MunicipalityShire { get; set; }

        string MeterNumber { get; set; }

        DateTime GasLeakCheck { get; set; }
    }
}