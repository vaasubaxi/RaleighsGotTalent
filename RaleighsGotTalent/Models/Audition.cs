namespace RaleighsGotTalent.Models
{
    public class Audition
    {
        public int Id { get; set; }
        public string VideoLink { get; set; }
        public DateTime AuditionDateSubmission { get; set; } = DateTime.Now;
        public String Status { get; set; } = "Pending";
        public int TeamId {  get; set; }
        public Team Team { get; set; }

    }
}
