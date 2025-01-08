namespace TTleaser.Web.Components.Models
{
#pragma warning disable
    // Teacher Model (Models/Teacher.cs)
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
    }

    // Lesson Model (Models/Lesson.cs)
    public class Lesson
    {
        public int LessonId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
#pragma warning restore
}
