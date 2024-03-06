using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOSAPIDemo.Model
{
    public class ResponseArray
    {
        public int out_num {  get; set; }
        public string out_str { get; set; }

    }
    public class ResponseArrayFull : ResponseArray
    {
        public string boarding_pass_number { get; set; }
        public int pax_id { get; set; }
    }
}
