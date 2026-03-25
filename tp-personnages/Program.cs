Personnage perso = new("Aurel", 100);
perso.Afficher();

Console.WriteLine("Après réception de dégâts");
perso.RecevoirDegats(15);
perso.Afficher();

Console.WriteLine("\n Partie 3 : Test override Afficher ");
Guerrier guerrier = new("Arthur", 100, 20);
Magicien magicien = new("Merlin", 80, 50);

guerrier.Afficher();
magicien.Afficher();

Console.WriteLine("\nPartie 5 : Surcharge RecevoirDegats ");
Personnage p1 = new("TestNormal", 100);
p1.RecevoirDegats(20);
Console.WriteLine("Sans réduction :");
p1.Afficher();

Personnage p2 = new("TestReduction", 100);
p2.RecevoirDegats(20, 10);
Console.WriteLine("Avec réduction :");
p2.Afficher();

foreach (Personnage p in personnages)
{
    p.Afficher();

    p.Attaquer(); 
}