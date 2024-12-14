namespace JobNet.Models
{
    public class RequestPostModel
    {
        public int RequestID { get; set; }
        public int JobID { get; set; }
        public int UserID { get; set; }
        public string Message { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
