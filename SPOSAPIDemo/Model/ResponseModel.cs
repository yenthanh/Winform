namespace SPOSAPIDemo.Model
{
    public class AddPaxRecordResponseModel : ResponseModel
    {
        public ResponseArrayFull[] data { get; set; }
    }
    public class UpdatePaxRecordResponseModel : ResponseModel
    {
        public ResponseArray data { get; set; }
    }
    public class CancelPaxRecordResponseModel : ResponseModel
    {
        public ResponseArray[] data { get; set; }
    }
    public class GetPaxResponseModel : ResponseModel
    {
        public GetPaxList[] data { get; set; }
    }
    public class GetTerminalListResponseModel : ResponseModel
    {
        public TerminalList[] data { get; set; }
    }
    public class TripInfoResponseModel : ResponseModel
    {
        public TripInfo[] data { get; set; }
    }
    public class TripListResponseModel : ResponseModel
    {
        public TripList[] data { get; set; }
    }
    public class LoginResponseModel : ResponseModel
    {
        public string data { get; set; }
    }
    public class VesselPaxCodeResponseModel : ResponseModel
    {
        public VesselPaxCode[] data { get; set; }
    }
    
    public class ResponseModel
    {
        public string error { get; set; }
        public string err_msg { get; set; }
        public string err_num { get; set; }
    }
    public class PaxId
    {
        public int pax_id { get; set; }
    }
    
}
