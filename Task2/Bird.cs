public class Bird
{
    List<int> BirdCount = new List<int>();
    public void AddBirdCount(List<int> values)
    {
        BirdCount=values;
    }
    public void LastWeek()
    {
        var tac=BirdCount.TakeLast(7);
        foreach (var item in tac)
        {
                System.Console.Write(item+" ");
        }
    }
}