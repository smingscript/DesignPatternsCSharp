public interface IIterator
{
    /// <summary>
    /// 다음에 읽을(순회할) 마린이 있나
    /// </summary>
    /// <returns></returns>
    bool HasNext();
    
    /// <summary>
    /// 현재 방문하는 마린
    /// </summary>
    /// <returns></returns>
    Marine GetCurrent();
}