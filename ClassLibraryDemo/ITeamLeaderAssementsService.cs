namespace ClassLibraryDemo
{
    /// <summary>
    /// This is our Interface
    /// </summary>
    public interface ITeamLeaderAssementsService
    {

        /// <summary>
        /// IntegrateAssesments gets data from Outsystems and bla bla bla
        /// </summary>
        Task IntegrateAssesments();
        Task TryFailingInsert();
        Task UploadAreas();
        Task UploadAssesments();
        Task UploadFaultyAreas();

        /// <summary>
        /// Upload Shifts does something
        /// </summary>
        Task UploadShifts();
    }

}