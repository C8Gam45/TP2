Personnage perso = new("Aurel", 100);
perso.Afficher();

Console.WriteLine("--- Après réception de dégâts ---");
perso.RecevoirDegats(15);
perso.Afficher();

Console.WriteLine("\n=== Partie 2 ===");
Guerrier guerrier = new("Thor", 120, 10);
Magicien magicien = new("Merlin", 80, 50);

guerrier.Afficher();
Console.WriteLine();
magicien.Afficher();


