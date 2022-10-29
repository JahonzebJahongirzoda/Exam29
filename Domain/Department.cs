namespace Domain;

public class Department
{
    public int DepartmentID { get; set; }
    public string? Name { get; set; }
    public string? Budget { get; set; }
    public DateTime StartDate { get; set; }



    public int InstructorID { get; set; }
    public virtual Instructor? Instructor { get; set; }




    public virtual List<Course>? Course { get; set; }
}
