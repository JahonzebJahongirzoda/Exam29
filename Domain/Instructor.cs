namespace Domain;

public class Instructor
{
    public int ID { get; set; }
    public string? LastName { get; set; }
    public string? FirstMidName { get; set; }
    public DateTime HireDate { get; set; }



    public virtual List<OfficeAssignment>? OfficeAssignments { get; set; }
    public virtual List<CourseAssignment>? CourseAssignment { get; set; }
    public virtual List<Department>? Departments { get; set; }





}
