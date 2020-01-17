namespace CommandPattern.Interfaces
{
    public interface ICommand
    {
        void ExecuteAction();
        void UndoAction();
    }
}
