namespace Classes
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
