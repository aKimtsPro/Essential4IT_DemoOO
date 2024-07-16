namespace Demo00UsingTry;

public class Competition
{
    private List<Joueur> Participants { get; set; } = new List<Joueur>();
    public bool Lancee { get; private set; }
    
    // 1. On ne peut pas lancer une compet sans min 3 part.
    // 2. On ne peut pas inscrire 2x un participant
    // 3. On ne peut pas inscrire/desinscrire un part. après lancement

    public void Inscrire(Joueur j)
    {
        if (Participants.Contains(j))
            throw new Exception();

        if (Lancee)
            throw new Exception();
        
        Participants.Add(j);
    }

    public void Desinscrire(Joueur j)
    {
        
    }

    public void Lancer()
    {
        this.Lancee = true;
    }
    
}