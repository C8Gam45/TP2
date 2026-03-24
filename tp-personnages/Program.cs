// TP Héritage Partie 1 : Classe de base Personnage
Personnage perso = new("Aurel", 100);
perso.Afficher();

Console.WriteLine("--- Après réception de dégâts ---");
perso.RecevoirDegats(15);
perso.Afficher();

// Attendu : nom affiché; points de vie diminués

