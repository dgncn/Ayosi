namespace Ayosi.Interfaces
{
    /// <summary>
    /// This interface contains Container's base methods 
    /// </summary>
    public interface IBaseContainer : IRegistrationManager, ISingleton, IResolveManager
    {

    }
}