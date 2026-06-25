namespace TrainingDirectory.Api.Services;

public interface IDirectoryService
{
    Task<ProcessingProfileResponse?> GetProfileAsync(long traineeId);
}