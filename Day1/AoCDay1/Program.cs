// See https://aka.ms/new-console-template for more information
var input = File.ReadAllLines(@"input.txt");

var inputList = new List<string>();
var startValue = 50; 
int count = 0;
foreach (string text in input)
{
    inputList.Add(text);
}

var rows = inputList.Count();

foreach (string text in inputList)
{
    if(text[0].ToString() == "L")
    {
        int number = Int32.Parse(text.Substring(1));
        startValue = startValue - number;
        startValue = startValue % 100;
    }
    else if(text[0].ToString() == "R")
    {
        int number = Int32.Parse(text.Substring(1));
        startValue = startValue + number;
        startValue = startValue % 100;
    }

    if (startValue == 0)
    {
        count++;
    }

}
Console.WriteLine(count);
