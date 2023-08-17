using System.ComponentModel.DataAnnotations;

namespace UserTasks.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string TaskName { get; set; }
        public DateTime ExpiryDate { get; set; }

        public string Users { get; set; }

        public bool IsImportant { get; set; }
    }
}
