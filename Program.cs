using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt user for patient information
        Console.WriteLine("Enter patient information:");
        
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();
        
        Console.Write("Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Weight (in kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Height (in cm): ");
        double height = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Systolic Blood Pressure (mm Hg): ");
        int systolic = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Diastolic Blood Pressure (mm Hg): ");
        int diastolic = Convert.ToInt32(Console.ReadLine());

        // Create patient object with user-provided information
        Patient patient = new Patient(firstName ?? "", lastName ?? "", weight, height, age);

        // Print patient information
        string patientInfo = patient.GetPatientInformation(systolic, diastolic);
        Console.WriteLine("\nPatient Information:");
        Console.WriteLine(patientInfo);
    }
}