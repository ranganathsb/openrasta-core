namespace OpenRasta.Configuration.Fluent
{
    public interface IUriDefinition  : IRepeatableDefinition<IResourceDefinition>, IHandlerParentDefinition
    {
        IUriDefinition Named(string uriName);
        IUriDefinition Language(string language);
    }
}