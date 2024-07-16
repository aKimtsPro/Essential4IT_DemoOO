namespace DemoStatic;

// Cette classe donne une exemple de la mise en application
// du design pattern 'Singleton' utilisant le mot-clef 'static'
// https://refactoring.guru/design-patterns/singleton
public class Singleton
{

    private static Singleton? _instance;

    public static Singleton Instance
    {
        get {
            return _instance == null ? _instance = new Singleton():_instance;
        }
    }
    
    private Singleton(){}
}