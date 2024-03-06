using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOSAPIDemo.Model
{
    public class ResponseModel
    {
        public ResponseArrayFull[] data { get; set; }
        public string error { get; set; }
        public string err_msg { get; set; }
        public string err_num { get; set; }
    }
}
