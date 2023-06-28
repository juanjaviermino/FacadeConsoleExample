class Program
{
    static void Main(string[] args)
    {
        VacationPlanner vacationPlanner = new VacationPlanner();

        Console.WriteLine("Bienvenido al Vacation Planner!");
        Console.Write("Ingresa la ciudad destino: ");
        string destination = Console.ReadLine();

        Console.Write("Ingresa la ubicación de acomodación: ");
        string accommodationLocation = Console.ReadLine();

        Console.Write("Ingresa la duración de tu viaje (días): ");
        int duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        vacationPlanner.PlanVacation(destination, accommodationLocation, duration);

        Console.ReadKey();
    }

}