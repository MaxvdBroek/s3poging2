namespace ForestAPI.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
