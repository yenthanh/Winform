using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOSAPIDemo.Model
{
    public class PaxDetails
    {
        public string passport_no { get; set; }
        public string passport_type { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string gender { get; set; }
        public string nationality { get; set; }
        public string dob { get; set; }
        public string country_of_birth { get; set; }
        public string travel_doc_exp_date { get; set; }
        public string country_of_issue { get; set; }
        public string country_of_residence { get; set; }
        public string destination { get; set; }
        public string ticket_no { get; set; }
        public string remarks { get; set; }
        public string cabin { get; set; }
        public string pax_type { get; set; }
        public int bag_allowance { get; set; }
        public int additional_bag_allowance { get; set; }
        public string security_program_flag { get; set; }
        public string membership_no { get; set; }
        public List<string> ssr { get; set; }
    }
    public class PaxDetailsAdd : PaxDetails
    {
        public string customer_book_code { get; set; }
        public int check_in { get; set; }
        public string source_check_in { get; set; }
    }
}
