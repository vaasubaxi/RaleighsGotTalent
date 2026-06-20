namespace RaleighsGotTalent.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Caption { get; set; }
        public int Year { get; set; }
        public DateTime UploadDate { get; set; } = DateTime.Now;

    }
}
