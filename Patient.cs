using System;

public class Patient
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double WeightInKg { get; set; }
    public double HeightInCm { get; set; }
    public int Age { get; set; }

    // Constructor
    public Patient(string firstName, string lastName, double weightInKg, double heightInCm, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        WeightInKg = weightInKg;
        HeightInCm = heightInCm;
        Age = age;
    }

    // Method to calculate blood pressure
    public string CalculateBloodPressure(int systolic, int diastolic)
    {
        string bloodPressureResult = "";

        // Logic for calculating blood pressure based on given systolic and diastolic values
        
        if (systolic < 120 || diastolic < 80)
        {
            bloodPressureResult = "Normal blood pressure";
        }
        else if (systolic >= 120 && systolic < 129 && diastolic < 80)
        {
            bloodPressureResult = "Elevated blood pressure";
        }
        else if (systolic >= 130 && systolic < 139 && diastolic >= 80 && diastolic <= 89)
        {
            bloodPressureResult = "High blood pressure (HYPERTENSION) Stage1";
        }
        else if (systolic >= 140 && systolic <= 180 && diastolic >= 90 && diastolic <= 120)
        {
            bloodPressureResult = "High blood pressure (HYPERTENSION) Stage2";
        }
        else if (systolic > 180 || diastolic > 120)
        {
            bloodPressureResult = "HYPERTENSIVE CRISIS (consult your doctor immediately)";
        }

        return bloodPressureResult;
    }

    // Method to calculate BMI (Body Mass Index)
    public double CalculateBMI()
    {
        // Convert height from cm to m
        double heightInMeter = HeightInCm / 100;

        // Calculate BMI using the formula: BMI = kg/m^2
        return WeightInKg / (heightInMeter * heightInMeter);
    }

    // Method to get patient information
    public string GetPatientInformation(int systolic, int diastolic)
    {
        // Calculate blood pressure
        string bloodPressureResult = CalculateBloodPressure(systolic, diastolic);

        // Calculate BMI
        double bmi = CalculateBMI();

        // Determine BMI status
        string bmiStatus = "";
        if (bmi >= 25.0)
        {
            bmiStatus = "Overweight";
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            bmiStatus = "Normal (In the healthy range)";
        }
        else
        {
            bmiStatus = "Underweight";
        }

        // Construct patient information string
        string patientInfo = $"Full Name: {FirstName} {LastName}\n" +
                             $"Age: {Age}\n" +
                             $"Weight: {WeightInKg} kg\n" +
                             $"Height: {HeightInCm} cm\n" +
                             $"Blood Pressure: {bloodPressureResult}\n" +
                             $"BMI: {bmi}\n" +
                             $"BMI Status: {bmiStatus}";

        return patientInfo;
    }
}