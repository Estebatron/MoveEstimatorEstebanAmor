using System;
using System.Globalization;
class Program {
  public static void Main (string[] args) {

    Console.WriteLine ("Please Input the number of hours worked");
    var H = Console.ReadLine();
    Console.WriteLine ("Please Input the number of miles traveled");
    var M = Console.ReadLine();

    var splitH = H.Split(' ');
    var splitM = M.Split(' ');

    var Hours = splitH[0];
    var Miles = splitM[0];

    double HoursWorked;
    double MilesTraveled;

    if (double.TryParse(Hours, out HoursWorked) && double.TryParse(Miles, out MilesTraveled)){
   var totalCost= ((200 + (MilesTraveled * 2) + (HoursWorked * 150)).ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
      Console.WriteLine(totalCost);
    }
    else{
      Console.WriteLine("Invalid Input");
    }
  }
}