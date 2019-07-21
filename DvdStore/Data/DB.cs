using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvdStore.Data
{
    public class DB
    {
        public CustomerData Customer { get; } = new CustomerData();
        public DvdData Dvd { get;  } = new DvdData();
        public RentalData Rental { get; } = new RentalData();

    }
}
