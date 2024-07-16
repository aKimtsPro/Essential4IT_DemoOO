namespace Demo00UsingTry;

public class ExemplePropagation
{
    public void Method1()
    {
        try
        {
            Method2();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    
    
    public void Method2()
    {
        Method3();
    }
    
    public void Method3()
    {
        Method4();
    }
    
    public void Method4()
    {
        Method5();
    }
    
    public void Method5()
    {
        throw new Exception("Exception de la methode 5");
    }
}