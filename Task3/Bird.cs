
public class BirdCount
{
    int[] _birdsPerDay ;

    public BirdCount(int[] birds)
    {
        _birdsPerDay = birds;
    }

        public int Today()
    {
        return _birdsPerDay[_birdsPerDay.Length - 1]; // Получаем количество птиц за сегодня
    }

}