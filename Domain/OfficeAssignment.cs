namespace Domain;

public class OfficeAssignment
{
    public int InstructorID { get; set; }

    public virtual Department? Department { get; set; }



    public string? Location { get; set; }


}
