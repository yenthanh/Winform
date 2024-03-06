using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SPOSAPIDemo.Model
{
    
    public class SmCheckIn
    {
      
        public int trip_id { get; set; }
        public string voyage_date { get; set; }
        public List<int> pax_details { get; set; }
    
    }
} 