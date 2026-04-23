
LogisticBase roadLogistic = new RoadLogistic();
roadLogistic.DeliveryByTransport();
LogisticBase waterLogistic = new WaterWaysLogistic();
waterLogistic.DeliveryByTransport();


public interface ITransport
{
    void Transport();
}

public class Ship : ITransport
{
    public void Transport() => Console.WriteLine("Ship are transporting");
}

public class Truck : ITransport
{
    public void Transport() => Console.WriteLine("Truck are transporting");
}

public abstract class LogisticBase
{
    public abstract ITransport CreateTransport();
    public void DeliveryByTransport()
    {
        ITransport transport = CreateTransport();
        Console.WriteLine($"Transport by {this.GetType().Name}");
        transport.Transport();
    }
}

public class RoadLogistic : LogisticBase
{
    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}

public class WaterWaysLogistic : LogisticBase
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}