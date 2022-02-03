using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMedicine
{
    public class CartonDetail
    {
        public Medicine Medicine { get; set; }
        public int MedicineStripCount { get; set; }
        public DateTime LaunchDate { get; set; }
        public string RetailerAddress { get; set; }
        public double TotalAmount { get; set; }
    }
}
