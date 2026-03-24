Personnage perso = new("Aurel", 100);
perso.Afficher();

Console.WriteLine("--- Après réception de dégâts ---");
perso.RecevoirDegats(15);
perso.Afficher();

Console.WriteLine("\n=== Partie 3 : Test override Afficher ===");
Guerrier guerrier = new("Arthur", 100, 20);
Magicien magicien = new("Merlin", 80, 50);

guerrier.Afficher();
magicien.Afficher();


