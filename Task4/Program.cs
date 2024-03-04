
int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
var birdCount = new BirdCount(birdsPerDay);
birdCount.IncrementTodaysCount();

System.Console.WriteLine(birdCount.Today());