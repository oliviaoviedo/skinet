using System;

namespace API.RequestHelpers;

public class Pagination<T>(int PageIndex, int PageSize, int count, IReadOnlyList<T> data)
{
    public int PageIndex { get; set; } = PageIndex;
    public int PageSize { get; set; } = PageSize;
    public int Count { get; set; } = count;
    public IReadOnlyList<T> Data { get; set; } = data;
}
