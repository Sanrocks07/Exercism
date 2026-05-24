
class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        // throw new NotImplementedException("Please implement the (static) BirdCount.LastWeek() method");
        int[] bird = { 0, 2, 5, 3, 7, 8, 4 };
        return bird;

    }

    public int Today()
    {
        // throw new NotImplementedException("Please implement the BirdCount.Today() method");
        //         return birdsPerDay[birdsPerDay.Length - 1];

        return birdsPerDay[birdsPerDay.Length-1];
    }

    public void IncrementTodaysCount()
    {
        // throw new NotImplementedException("Please implement the BirdCount.IncrementTodaysCount() method");
         birdsPerDay[birdsPerDay.Length-1]++;
    }

    public bool HasDayWithoutBirds()
    {
        // throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");
        foreach(int bird in birdsPerDay)
        {
            if(bird == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        // throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");
        var count = 0;
        for(int i=0 ; i < numberOfDays; i++)
        {
            count = count + birdsPerDay[i];
        }
        return count;
    }

    public int BusyDays()
    {
        // throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
        var busyDay = 0;
        for(int i = 0 ; i < birdsPerDay.Length ; i++)
        {
            if(birdsPerDay[i]>= 5)
            {
                busyDay++;
            }
        }
        return busyDay;
    }
}
