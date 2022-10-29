namespace Domain;

public class CourseAssignment
{

    public int CourseID { get; set; }
    public int InstructorID { get; set; }
    public virtual Department? Department { get; set; }

}
