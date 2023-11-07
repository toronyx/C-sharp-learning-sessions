using Remote_Control_Car_Racing.Vehicles;
using Remote_Control_Car_Racing.RaceTracks;
using System.Diagnostics;


// Instantiate two cars, of type RemoteControlCar
var car1 = new RemoteControlCar(10, 10, "somewhat-sppeedy");
var car2 = new RemoteControlCar(12, 10, "bitmore-speedy");

// Instantiate an instance of RaceTrack with distance 100
var raceTrack = new RaceTrack(100);

var car1CanFinishTheRace = raceTrack.CanFinishRace(car1);
var car2CanFinishTheRace = raceTrack.CanFinishRace(car2);


if (car1CanFinishTheRace)
{
    Debug.WriteLine($"Car 1 can finish the race");
}
else
{
    Debug.WriteLine($"Car 1 can't finish the race");
}