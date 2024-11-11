using System.Collections.Generic;
using System.Reflection;

namespace Saunter;

public class EmptyConventionsProvider : IAsyncApiConventionsProvider
{
    public IEnumerable<TypeInfo> GetConsumers(string? apiName) => new List<TypeInfo>();

    public IEnumerable<TypeInfo> GetPublishers(string? apiName) => new List<TypeInfo>();

    public IEnumerable<TypeInfo> GetMessages(string? apiName) => new List<TypeInfo>();
}