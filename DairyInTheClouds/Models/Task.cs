namespace DairyInTheClouds.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        // Foreign key
        public int JournalId { get; set; }

        // Navigation property
        public virtual Journal Journal { get; set; }
    }
}
