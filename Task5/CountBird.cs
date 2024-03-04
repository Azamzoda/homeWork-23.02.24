
public class BirdCount
{
    int[] _birdsPerDay ;

    public BirdCount(int[] birds)
    {
        _birdsPerDay = birds;
    }


        public bool HasDayWithoutBirds()
    {
        return _birdsPerDay.Any(cnt => cnt >= 0); 
    }


}