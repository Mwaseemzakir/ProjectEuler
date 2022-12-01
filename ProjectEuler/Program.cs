using ProjectEuler.Core.Data;
using ProjectEuler.Core.IO;
using ProjectEuler.Core.Utilities;

Console.WriteLine("Which problem's solution you would like to see !");
int problemNo = 0;
bool isValidNumber = Int32.TryParse(Console.ReadLine(), out problemNo);
if(isValidNumber)
{
    string html = await UrlReader.ReadUrl("https://projecteuler.net/minimal=1");
    string text = HtmlConverter.HtmlToText(html);
    Console.WriteLine(text);
}
else
{
    ConsoleUtility.WriteLine(Result.InvalidInput);
}
