
namespace TrainingDirectory.Api.Services;

public class DirectoryService : IDirectoryService
{
    public async Task<ProcessingProfileResponse?> GetProfileAsync(long traineeId)
    {
        var response = new ProcessingProfileResponse
        {
            TraineeId = traineeId,
            FirstName = "Tanish",
            LastName = "Rai",
            Email = "tr@gmial.com",
            TechStack = "java",
            AssignmentTitle = "Whatever",
            AssignmentStatus = "Assigned"
        };

        return await Task.FromResult(response);
    }
}