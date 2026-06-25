namespace TrainingDirectory.Api;

public class TraineeProfileResponse
{
    public long TraineeId {get; set;}
    public string FirstName {get; set;} = string.Empty;
    public string LastName {get; set;} = string.Empty;
    public string Email {get; set;} = string.Empty;
    public string TechStack {get; set;} = string.Empty;
    public string AssignmentTitle {get; set;} = string.Empty;
    public string AssignmentStatus {get; set;} = string.Empty;
}