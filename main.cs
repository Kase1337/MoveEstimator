using System;

class Program {
  public static void Main (string[] args) {

    // Declared base variable
    double base_rate  = 200.0;
    
    // declared hour and hourly rate variables
    double hours;
    double hourly_rate = 150.0;
    
    //declared miles and rate per mile variables
    double miles;
    double rate_per_mile = 2.0;
    
    //declared total variable
    double total;
    
    // Prompt the user to enter the hours
    Console.Write("Please enter the required hours for the move: ");
    // Read and convert the entered value to string
    hours = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("Please enter the required miles for the move: ");
     // Read and convert the entered value to string
     miles = Convert.ToDouble(Console.ReadLine());
    
     // Use the calcultion formula to calculate the total
    total = calculateresults(base_rate, hours, hourly_rate, miles, rate_per_mile);
    // Print out the total moving fee stored in the total variable to the console
    Console.WriteLine("$"+ total);
    
  }
   // This syntax calculates the total moving fee by adding the base rate, the total hourly charges, and the total mileage charges then it returns the value to the total variable.
 public static double calculateresults(double baseRate, double hours, double hourly_rate, double miles, double rate_per_mile)
  {
      return baseRate + (hours * hourly_rate) + (miles * rate_per_mile);
 }

}