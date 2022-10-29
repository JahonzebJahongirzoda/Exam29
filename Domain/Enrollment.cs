namespace Domain;

public class Enrollment
{
    public int EntrollmentID { get; set; }


    public int CourseID { get; set; }
    public virtual Course? Course { get; set; }



    public int StudentID { get; set; }
    public virtual Student? Student { get; set; }


    public int Grade { get; set; }






}
