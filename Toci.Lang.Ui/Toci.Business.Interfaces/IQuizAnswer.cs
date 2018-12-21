namespace Toci.Business.Interfaces
{
    public interface IQuizAnswer : IQuizQuestion
    {
        bool IsCorrect { get; set; }

        
    }
}