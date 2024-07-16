namespace DemoStatic;

public class ToDispose : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("Objet supprimé par le GC");
    }
}