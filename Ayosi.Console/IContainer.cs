namespace ConsoleApp1
{
    public interface IContainer
    {
        void AddService(object service);
        string Summary();
    }
}