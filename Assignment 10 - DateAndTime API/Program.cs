using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

DateTime currentDate = DateTime.Now; /*.ToString("yyyy-MM-dd HH:mm");*/
Console.WriteLine("date in Tbilisi: " + currentDate.ToString("yyyy-MM-dd HH:mm"));

DateTime LondonDate = currentDate.AddHours(-4);

Console.WriteLine("date in London: " + LondonDate.ToString("yyyy-MM-dd HH:mm"));

var date1 = new DateTime(1999, 4, 16);
var date2 = DateTime.Today;

TimeSpan difference = date2 - date1;
var daysBetween = difference.Days;
Console.WriteLine("There are this many days between today and the day I was born: " + daysBetween);
var exampleYear = 2023;
bool IsLeap = DateTime.IsLeapYear(exampleYear);
Console.WriteLine($"it is {IsLeap} that {exampleYear} is a Leap year");

var previousMonth = date2.AddMonths(-1);
var FirstDayOfPreviousMonth = previousMonth.AddDays(-(date2.Day - 1));
Console.WriteLine("First day of Previous month " + FirstDayOfPreviousMonth.ToString("yyyy-MM-dd HH:mm"));


var LastDayOfPreviousMonth = date2.AddDays(-date2.Day);
Console.WriteLine("Last day of Previous month " + LastDayOfPreviousMonth.ToString("yyyy-MM-dd HH:mm"));

var weekday = DateTime.Now.DayOfWeek;
//Console.WriteLine(weekday);
var filePath = "C:\\Users\\lenno\\Desktop\\Translator\\weekdaysTranslations.txt";  // here I have txt file that
var filereader = File.ReadAllLines(filePath);             // includes translation of weekdays from Eng to Geo

Translator translator = new Translator();

for (int i = 0; i < filereader.Length; i++)
{
    var line = filereader[i];

    var separators = new char[] { ',', ';' };
    var lineParts = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    translator.Eng = lineParts[0];
    translator.Geo = lineParts[1];

    if (translator.Eng == weekday.ToString())
        break;

}

var translatedWeekday = translator.Geo;
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine(translatedWeekday);
