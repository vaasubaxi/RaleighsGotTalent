namespace RaleighsGotTalent.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string TimeSlot { get; set; }
        public string Description { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }

    }
}
