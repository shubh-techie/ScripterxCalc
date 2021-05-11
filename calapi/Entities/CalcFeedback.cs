namespace calapi.Entities
{
    public class CalcFeedback
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string EmailID { get; set; }
        public string Feedback { get; set; }
        public bool IsLike { get; set; }
    }
}