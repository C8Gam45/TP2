public class Personnage
{
    protected string nom;
    protected int pointsDeVie;

    public Personnage(string nom, int pointsDeVie)
    {
        this.nom = nom;
        this.pointsDeVie = pointsDeVie;
    }
   

    public virtual void RecevoirDegats(int degats)
    {
        if (degats < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(degats), "Les dégâts doivent être positifs.");
        }

        pointsDeVie -= degats;

        if (pointsDeVie < 0)
        {
            pointsDeVie = 0;
        }
    }

    public virtual void RecevoirDegats(int degats, int reduction)
    {
        degats -= reduction;
        if (degats < 0)
        {
            degats = 0;
        }
        RecevoirDegats(degats);
    }

    public virtual void Afficher()
    {
        Console.WriteLine($"Nom : {nom}");
        Console.WriteLine($"Points de vie : {pointsDeVie}");
    }
}
