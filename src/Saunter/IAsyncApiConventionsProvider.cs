using System.Collections.Generic;
using System.Reflection;

namespace Saunter;

public interface IAsyncApiConventionsProvider
{
    IEnumerable<TypeInfo> GetConsumers(string? apiName);
    IEnumerable<TypeInfo> GetPublishers(string? apiName);
    IEnumerable<TypeInfo> GetMessages(string? apiName);
}