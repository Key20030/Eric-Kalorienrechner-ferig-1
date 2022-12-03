// See https://aka.ms/new-console-template for more information
Console.WriteLine("  =============================");
Console.WriteLine(" |Wilkommen zum Kalorienrechner|");
Console.WriteLine("  =============================");
Console.WriteLine((""));
Console.WriteLine();
Console.WriteLine(("Bitte geben sie ihr Gewicht in kg an!"));
double Gewicht = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(("Bitte geben sie ihre Körpergröße in cm an!"));
double Körpergröße = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(("Bitte geben sie ihr Alter in Jahren an!"));
double Alter = Convert.ToDouble(Console.ReadLine());

int Gewichd = (int)Gewicht;
int Körpergroeße = (int)Körpergröße;
int Alt = (int)Alter;
Console.WriteLine((""));
Console.WriteLine((""));
Console.WriteLine((""));
Console.WriteLine((""));
Console.WriteLine((""));

double a;
a = 655.1;

double b;
b = 9.6;

double c;
c = 1.8;

double d;
d = 4.7;

double e;
e = 2.2;

double f = a + (b * Gewichd) + (c * Körpergroeße) - (d * Alt);
Console.WriteLine("Jetz erhalten sie ihren Grundumsatz!:");
Console.WriteLine(f);
Console.WriteLine((""));
double g = e * f;
Console.WriteLine("Jetz erhalten sie ihren Leistungsumsatz!:");
Console.WriteLine(g);

Console.WriteLine((""));
Console.WriteLine("Jetz erhalten sie ihren Gesamtumsatz(Wert mit sport um Musskelmasse zu erhalten!):");
double h = f + g;
Console.WriteLine(h);

Console.WriteLine("  ==============================");
Console.WriteLine(" |Danke für ihre Nutzung der App|");
Console.WriteLine("  ==============================");

