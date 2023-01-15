// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
var TCW = "0";
var KW = "0";
var FW = "0";
var TCG = "0";
var KG = "0";  

Console.Write("T/C grade weight as a %: ");
TCW =Console.ReadLine();
decimal TCWD;
Decimal.TryParse(TCW, out TCWD);
Console.Write("K grade weight as a %: ");
KW = Console.ReadLine();
decimal KWD;
Decimal.TryParse(KW, out KWD);
Console.Write("Finals grade weight as a %: ");
FW = Console.ReadLine();
decimal FWD;
Decimal.TryParse(FW, out FWD);
Console.Clear();

Console.Write("Current T/C grade as a %: ");
TCG = Console.ReadLine();
decimal TCGD;
Decimal.TryParse(TCG, out TCGD);
Console.Write("Current K grade as a %: ");
KG = Console.ReadLine();
decimal KGD;
Decimal.TryParse(KG, out KGD);
Console.Clear();

decimal LPG = (TCWD * TCGD + KWD * KGD) / 100;
Console.WriteLine("Your lowest possible grade is: " + LPG);
decimal HPG = LPG + FWD;
Console.WriteLine("Your highest possible grade is: " + HPG);
decimal CA = (TCWD * TCGD + KWD * KGD) / (TCWD+KWD);
Console.WriteLine("Your current grade average is: " + CA);
decimal a = FWD / 100;
Console.WriteLine();
Console.WriteLine("The graph showing subject average over Finals grade: y =" + a + "x +" + LPG);
Console.WriteLine();
Console.WriteLine("Please plug this formula into https://www.desmos.com/calculator?lang=nl to get a graph of you grade. \r\n");
Console.WriteLine("The y axis is your total average grade after finals and x is your grade for finals.\r\n");
Console.ReadLine();