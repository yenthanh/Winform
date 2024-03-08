using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPOSAPIDemo.Model
{
    public class GetPaxList
    {
        public string pax_id {  get; set; }
        public string passport_number {  get; set; }
        public string ticket_number {  get; set; }
        public string last_name {  get; set; }
        public string first_name {  get; set; }
        public string customer_booking_code {  get; set; }

        [JsonProperty("class")]
        public string pax_class { get; set; }
        public string dcs_booking_code {  get; set; }
        public string cabin {  get; set; }
        public string passport_type {  get; set; }
        public int boarding_sequence {  get; set; }
        public string boarding_pass_number {  get; set; }
        public string gender {  get; set; }
        public string pax_type {  get; set; }
        public string dob {  get; set; }
        public string nationality {  get; set; }
        public string membership_no {  get; set; }
        public string travel_document_issuing_country {  get; set; }
        public string travel_document_exp_date {  get; set; }
        public string country_issue { get; set; }
        public string country_residence {  get; set; }
        public int bag_allowance { get; set; }
        public int additional_baggage_allowance { get; set; }
        public string ssr {  get; set; }
        public string baggage_tag_number {  get; set; }
        public string baggage_type { get; set; }
        public int checkin { get; set; }
        public int pre_imm { get; set; }
        public int boarding { get; set; }
        public int pontoon { get; set; }
        public string destination {  get; set; }
        public string security_program_flag { get; set; }
        public Boolean group_travel_flag {  get; set; }
        public int immigration { get; set; }
        public string source_check_in { get; set; }
         public int last_min_pax { get; set; }
        public int ntl_flag { get; set; }
        public string transfer_from { get; set; }
        public string remarks {  get; set; }
       
        public int cancelled {  get; set; }
        public string date_created {  get; set; }
        public string create_by { get; set; }
        public string date_updated {  get; set; }
        public string updated_by { get; set; }
    }
}
