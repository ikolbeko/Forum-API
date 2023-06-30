namespace Forum.Models.Entities;

public class Page<T> where T : class
{
    public int Total { get; private set; }
    public int PageSize { get; private set; }
    public List<T> List { get; private set; }
    public Page(List<T> list, int pageSize, int total)
    {
        List = list;
        PageSize = pageSize;
        Total = total;
    }

}