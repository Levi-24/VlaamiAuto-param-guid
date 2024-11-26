using VlaamiAuto;

Auto auto = new Auto("AAA-111", "Nissan", "Skyline GTR R32", 2568, 280, 15.5f, ["Halálhozó Szkófild", "Levike", "Áki"]);
Auto auto1 = new Auto("PPP-222");

string[] nevek = ["Halálhozó Szkófild", "Levike", "Áki"];

//auto.UjTulajokRogzitese(nevek);
//auto.UjTulajokRogzitese("Halálhozó Szkófild", "Levike", "Áki");

Console.WriteLine(auto);
Console.WriteLine(auto.TulajdonosokLekerdezese());
Console.WriteLine();
Console.WriteLine(auto1);
Console.WriteLine(auto1.TulajdonosokLekerdezese());