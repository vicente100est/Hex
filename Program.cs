using Hex;
using System.Text.RegularExpressions;

string txt;

Console.WriteLine("Escribe la palabra que quieras poner sus caracteres al revés");
txt = Console.ReadLine();

txt = Regex.Replace(txt, @"\s+", " ").Trim();

var words = txt.Split(' ');

foreach (var word in words)
{
    string txtReverse = Helpers.Reverse($"{word} ");

    Console.Write(txtReverse);
}
