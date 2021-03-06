namespace Reactive.Config
{
    public interface IKeyPathProvider
    {
        string GetKeyPath<T>() where T : class, IConfigured, new();
    }

    public class NamespaceKeyPathProvider: IKeyPathProvider
    {
        public string GetKeyPath<T>() where T : class, IConfigured, new()
        {
            var type = typeof(T);
            
            return type.FullName;
        }
    }
}
