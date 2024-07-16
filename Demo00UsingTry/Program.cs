// See https://aka.ms/new-console-template for more information


// // TextWriter tw = File.CreateText("leFichier.txt");
// //
// // tw.Write("salut");
// //
// // tw.Dispose();
//
// using ( TextWriter tw = File.CreateText("leFichier.txt") )
// {
//     tw.Write("salut");
// }


using Demo00UsingTry;

Joueur j = new Joueur("Luc");

Competition c = new Competition();

c.Lancer();

Console.WriteLine("Inscription de Luc");
c.Inscrire(j);
// Console.WriteLine("Inscription de Luc");
// c.Inscrire(j);

new ExemplePropagation().Method1();