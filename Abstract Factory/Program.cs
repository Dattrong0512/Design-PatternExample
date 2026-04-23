IStyle modernStyle = new ModernStyle();
Furniture modernFurniture = new Furniture(modernStyle);
modernFurniture.Init();

IStyle classicStyle = new ClassicStyle();
Furniture classicFurniture = new Furniture(classicStyle);
classicFurniture.Init();

public interface IChair
{
    void Init();
}

public interface ITable
{
    void Init();
}

public class ClassicChair : IChair
{
    public void Init()
    {
        Console.WriteLine($"Create successful {typeof(ClassicChair)}");
    }
}

public class ModernChair : IChair
{
    public void Init()
    {
        Console.WriteLine($"Create successful {typeof(ModernChair)}");
    }
}

public class ClassicTable : ITable
{
    public void Init()
    {
        Console.WriteLine($"Create successful {typeof(ClassicTable)}");
    }
}

public class ModernTable : ITable
{
    public void Init()
    {
        Console.WriteLine($"Create successful {typeof(ModernTable)}");
    }
}

public interface IStyle
{
    IChair CreateChair();
    ITable CreateTable();
}

public class ClassicStyle : IStyle
{
    public IChair CreateChair()
    {
        return new ClassicChair();
    }

    public ITable CreateTable()
    {
        return new ClassicTable();
    }
}

public class ModernStyle : IStyle
{
    public IChair CreateChair()
    {
        return new ModernChair();
    }

    public ITable CreateTable()
    {
        return new ModernTable();
    }
}

public class Furniture
{
    private IChair chair;
    private ITable table;

    public Furniture(IStyle style)
    {
        chair = style.CreateChair();
        table = style.CreateTable();
    }

    public void Init()
    {
        chair.Init();
        table.Init();
    }
}