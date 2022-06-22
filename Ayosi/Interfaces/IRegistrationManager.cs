namespace Ayosi.Interfaces
{
    public interface IRegistrationManager
    {
        IBaseContainer Register<TInterfaceType, TImplementationType>() where TImplementationType : class, TInterfaceType;
    }
}