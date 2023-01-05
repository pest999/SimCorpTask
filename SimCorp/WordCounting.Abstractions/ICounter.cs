using System.Collections.Generic;

namespace WordCounting.Abstractions
{
    public interface ICounter
    {
        IReadOnlyDictionary<string, int> WordCountLogic(string input);
    }
}
