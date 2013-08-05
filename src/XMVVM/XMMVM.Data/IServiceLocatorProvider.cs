using Microsoft.Practices.ServiceLocation;

namespace XMMVM.Data
{
    public interface IServiceLocatorProvider
    {
         IServiceLocator ServiceLocator { get; }
    }
}