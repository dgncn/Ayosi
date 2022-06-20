namespace Ayosi.Interfaces
{
    public interface IRegisterable
    {
        IBaseContainer Register<TInterfaceType, TImplementationType>() where TImplementationType : TInterfaceType;
    }
}