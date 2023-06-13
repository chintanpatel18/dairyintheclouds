namespace DairyInTheClouds.Models
{
    public class Journal
    {
        public int JournalId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        // Navigation property
        public virtual ICollection<System.Threading.Tasks.Task> Tasks { get; set; }
    }
}