public class Guerrier : Personnage
{
    protected int armure;

    public Guerrier(string nom, int pointsDeVie, int armure) : base(nom, pointsDeVie)
    {
        this.armure = armure;
    }

    public override void RecevoirDegats(int degats)
    {
        degats -= armure;
        if (degats < 0)
        {
            degats = 0;
        }
        base.RecevoirDegats(degats);
    }

    public override void Afficher()
    {
        base.Afficher();
        Console.WriteLine($"Armure : {armure}");
    }
}