using System;

class WorkHours
{
    static void Main()
    {
        // inputs
        int hoursNeeded = int.Parse(Console.ReadLine());
        int daysAvail = int.Parse(Console.ReadLine());
        int productivity = int.Parse(Console.ReadLine());

        double workingHours = daysAvail * 12;
        workingHours -= workingHours * 0.1;
        workingHours *= productivity / 100D;

        Console.WriteLine((hoursNeeded > (int)workingHours) ? "No" : "Yes");
        Console.WriteLine("{0}", (int)workingHours - hoursNeeded);
    }
}