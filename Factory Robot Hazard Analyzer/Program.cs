public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Enter Arm Precision (0.0 - 1.0):");
        double.TryParse(Console.ReadLine(), out double armPrecision);

        Console.WriteLine("Enter Worker Density (1 - 20):");
        int.TryParse(Console.ReadLine(), out int workerDensity);

        Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical:");
        string? machineryState = Console.ReadLine();

        try
        {
            RobotHazardAuditor robotHazardAuditor = new RobotHazardAuditor();
            double risk = robotHazardAuditor.CalculateHazardRisk(armPrecision, workerDensity, machineryState);

            Console.WriteLine($"Robot Hazard Risk Score: {risk}");
        } catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}