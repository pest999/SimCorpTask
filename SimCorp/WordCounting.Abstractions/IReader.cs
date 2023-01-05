using System;

namespace WordCounting.Abstractions
{
    public interface IReader
    {
        string Read(string filePath);
    }
}
