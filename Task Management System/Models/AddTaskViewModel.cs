namespace Task_Management_System.Models
{
    public class AddTaskViewModel
    {
        required
        public string Title { get; set; }
        required
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public int Priority { get; set; }
    }
}
