using ProjectEuler.Core.Data;
using ProjectEuler.Core.IO;
using ProjectEuler.Core.Utilities;
using ProjectEuler.Solution.Problem11_20;

Console.WriteLine("Which problem's solution you would like to see !");
int problemNo = 0;
bool isValidNumber = Int32.TryParse(Console.ReadLine(), out problemNo);
if(isValidNumber)
{
    Console.WriteLine(" / / / / / / / / / / / / / / / / / /  P r o b l e m / / / / / / / / / / / / / / / / / /");
    string html = await UrlReader.ReadUrl("https://projecteuler.net/minimal=1");
    string text = HtmlConverter.HtmlToText(html);
    Console.WriteLine(text);
    Problem20.Solution();
}
else
{
    ConsoleUtility.WriteLine(Result.InvalidInput);
}
