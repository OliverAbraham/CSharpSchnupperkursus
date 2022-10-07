Console.WriteLine(@"   ____        _       ");
Console.WriteLine(@"  / __ \      (_)      ");
Console.WriteLine(@" | |  | |_   _ _ ____  ");
Console.WriteLine(@" | |  | | | | | |_  /  ");
Console.WriteLine(@" | |__| | |_| | |/ /   ");
Console.WriteLine(@"  \___\_\\__,_|_/___|  ");
Console.WriteLine(@"                       ");
// gemacht mit https://onlineasciitools.com/convert-text-to-ascii-art

Console.WriteLine();
Console.WriteLine("Welche Naturschutzorganisation führt einen Panda in ihrem Logo?");
Console.WriteLine("A Greenpeace");
Console.WriteLine("B Robin Wood");
Console.WriteLine("C WWF");
Console.WriteLine("D NABU");
var auswahl = Console.ReadLine();
if (auswahl.ToUpper() == "C")
	Console.WriteLine("richtig!");
else
	Console.WriteLine("leider falsch!");
	
Console.WriteLine();
Console.WriteLine("Welche Tiere übernehmen in George Orwells 'Farm der Tiere' das Kommando auf dem Hof?");
Console.WriteLine("A Die Pferde");
Console.WriteLine("B Die Schweine");
Console.WriteLine("C Die Hunde");
Console.WriteLine("D Die Schafe");
auswahl = Console.ReadLine();
if (auswahl.ToUpper() == "B")
	Console.WriteLine("richtig!");
else
	Console.WriteLine("leider falsch!");
	
Console.WriteLine();
Console.WriteLine("Wie heißt die größte heimische Wespenart?");
Console.WriteLine("A Hornisse");
Console.WriteLine("B Deutsche Wespe");
Console.WriteLine("C Biene");
Console.WriteLine("D Hummel");
auswahl = Console.ReadLine();
if (auswahl.ToUpper() == "A")
	Console.WriteLine("richtig!");
else
	Console.WriteLine("leider falsch!");
	
Console.WriteLine();
Console.WriteLine("Welche Frucht schoss Wilhelm Tell mit der Armbrust vom Kopf seines Sohnes?");
Console.WriteLine("A Banane");
Console.WriteLine("B Birne");
Console.WriteLine("C Apfel");
Console.WriteLine("D Kirsche");
auswahl = Console.ReadLine();
if (auswahl.ToUpper() == "C")
	Console.WriteLine("richtig!");
else
	Console.WriteLine("leider falsch!");

Console.WriteLine();
Console.WriteLine("Ende!");
