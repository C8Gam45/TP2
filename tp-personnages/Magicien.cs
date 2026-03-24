public class Magicien : Personnage
{
    protected int puissanceMagique;

    public Magicien(string nom, int pointsDeVie, int puissanceMagique) : base(nom, pointsDeVie)
    {
        this.puissanceMagique = puissanceMagique;
    }

    public override void Afficher()
    {
        base.Afficher();
        Console.WriteLine($"Puissance magique : {puissanceMagique}");
    }
}