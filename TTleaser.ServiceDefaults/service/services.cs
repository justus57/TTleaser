using TTleaser.Web.Components.Models;

namespace TTleaser.ApiService.service
{
    // Services/TeacherService.cs
    public class TeacherService
    {
        private List<Teacher> _teachers = new List<Teacher>();

        public IEnumerable<Teacher> GetTeachers() => _teachers;
        // 
        public void AddTeacher(Teacher teacher)
        {

        }
        // Asynchronous method for retrieving teachers
        public async Task<List<Teacher>> GetTeachersAsync()
        {
            // Simulate async operation (e.g., API call, database query)
            await Task.Delay(100);  // Simulated delay
            return _teachers;
        }
    }

    // Services/LessonService.cs
    public class LessonService
    {
        private List<Lesson> _lessons = new List<Lesson>();

        public IEnumerable<Lesson> GetLessons() => _lessons;

        public async Task AddLessonAsync(Lesson lesson)  // Add async version of the method
        {
            // Simulate async operation (e.g., API call or database interaction)
            await Task.Delay(100);  // Simulated delay
            lesson.LessonId = _lessons.Count + 1;
            _lessons.Add(lesson);
        }
    }
}

