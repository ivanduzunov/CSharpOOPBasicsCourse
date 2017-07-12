using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CarManager

{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private Garage garage;

    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.races = new Dictionary<int, Race>();
        this.garage = new Garage();
    }


    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        Car car = null;
        if (type == "Performance")
        {
            car = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
        }
        else
        {
            car = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
        }
        cars.Add(id,car);
    }
    public string Check(int id)
    {
        var car = cars[id];
        return car.ToString();
    }
    public void Open(int id, string type, int length, string route, int prizePool)
    {
        Race race = null;
        if (type == "Casual")
        {
            race = new CasualRace(length, route, prizePool);
        }
        else if (type == "Drag")
        {
            race = new DragRace(length, route, prizePool);
        }
        else
        {
            race = new DriftRace(length, route, prizePool);
        }
        races.Add(id, race);
    }
    public void Participate(int carId, int raceId)
    {
        Race race = races[raceId];
        Car car = cars[carId];
        if (!garage.ParkedCars.ContainsKey(carId))
        {
            race.Participants.Add(carId, car);
        }
    }
    public string Start(int id)
    {
        var race = races[id];
        var typeRace = race.GetType().Name;
        List<Car> winners = new List<Car>();

        if (race.Participants.Count == 0)
        {
            return $"Cannot start the race with zero participants.";
        }
        if (typeRace == "CasualRace")
        {
            winners = race.Participants.Values
                .OrderByDescending(p => (p.Horsepower / p.Acceleration) + (p.Suspension + p.Durability)).Take(3)
                .ToList();
        }
        else if (typeRace == "DragRace")
        {
            winners = race.Participants.Values.OrderByDescending(p => p.Horsepower / p.Acceleration).Take(3).ToList();
        }
        else
        {
            winners = race.Participants.Values.OrderByDescending(p => p.Suspension + p.Durability).Take(3).ToList();
        }
        //
        var result = $"{race.Route} - {race.Length}";
        int counter = 0;
        int performance = 0;
        int cash = 0;

        foreach (var car in winners)
        {
            result += Environment.NewLine;
            counter++;
            if (typeRace == "CasualRace")
            {
                performance = (car.Horsepower / car.Acceleration) + (car.Suspension + car.Durability);
            }
            else if (typeRace == "DragRace")
            {
                performance = (car.Horsepower / car.Acceleration);
            }
            else if(typeRace == "DriftRace")
            {
                performance = (car.Suspension + car.Durability);
            }
            if (counter == 1)
            {
                cash = (race.PrizePool * 50) / 100;
            }
            else if (counter == 2)
            {
                cash = (race.PrizePool * 30) / 100;
            }
            else
            {
                cash = (race.PrizePool * 20) / 100;
            }

            result += $"{counter}. {car.Brand} {car.Model} {performance}PP - ${cash}";
        }
        races.Remove(id);
        return result;
    }
    public void Park(int id)
    {
        if (races.Values.Where(r => r.Participants.ContainsKey(id)).Count() != 1)
        {
            garage.ParkedCars.Add(id, cars[id]);
        }
    }
    public void Unpark(int id)
    {
        garage.ParkedCars.Remove(id);
    }
    public void Tune(int tuneIndex, string addOn)
    {
        foreach (var car in garage.ParkedCars.Values)
        {
            car.TuneUp(tuneIndex, addOn);
        }
    }
}

