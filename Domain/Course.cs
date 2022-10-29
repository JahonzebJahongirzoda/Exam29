namespace Domain;

public class Course
{
    public int CourseID { get; set; }
    public string? Title { get; set; }
    public int Credits { get; set; }
    public int DepartmentID { get; set; }
    public virtual Department? Department { get; set; }
    public virtual List<Enrollment>? Enrollments { get; set; }
    public virtual List<CourseAssignment>? CourseAssignments { get; set; }

}
