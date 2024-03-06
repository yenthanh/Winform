using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOSAPIDemo.Model
{
    public class TripInfo
    {
        public string trip_id { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public string gate_id { get; set; }
        public string departure_status { get; set; }
        public string arrival_status { get; set; }
        public string checkin_status { get; set; }
        public string pre_imm_status { get; set; }
        public string boarding_status { get; set; }
        public string boarding_time { get; set; }
        public string boarding_close_time { get; set; }
        public string pre_imm_time { get; set; }
        public string pontoon_status { get; set; }
        public string trip_date { get; set; }
        public string stb { get; set; }
        public string stu { get; set; }
        public string atb { get; set; }
        public string atu { get; set; }
        public string etb { get; set; }
        public string etu { get; set; }
        public int vessel_id { get; set; }
        public string vessel_name { get; set; }
        public int checked_in { get; set; }

        public int total_checked_in { get; set; }
        public int pre_imm { get; set; }
        public int total_pre_imm { get; set; }
        public int boarding { get; set; }
        public int total_boarding { get; set; }
        public int pontoon { get; set; }
        public int total_pontoon { get; set; }
    }

    public class TripList : TripInfo
    {
        public string trip_code { get; set; }
    }
}
