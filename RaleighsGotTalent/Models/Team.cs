namespace RaleighsGotTalent.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string Category { get; set; }
        public string AgeGroup { get; set; }
        public string CaptainName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int NumMembers { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Pending";

    
    
    }
}
