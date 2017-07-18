using System.Collections.Generic;

public class DragRace : Race
    {
        public DragRace(int length, string route, int prizePool, Dictionary<int, Car> participants) : base(length, route, prizePool, participants)
        {
        }

        public override int GetPerformance(int id)
        {
        var car = this.Participants[id];

        return (car.HorsePower / car.Acceleration);
    }
    }