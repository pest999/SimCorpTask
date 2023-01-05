
using System.Collections.Generic;

namespace WordCounting.Abstractions
{
    public interface IDisplay
    {
        void Show(IReadOnlyDictionary<string, int> wordCounting);
    }
}