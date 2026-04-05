// See https://aka.ms/new-console-template for more information

using static System.Console;using System.Threading.Tasks.Dataflow;

class PaintingEstimate
{
    static void Main()
    {
        int length;
        int width;
        double paintingCost;
        Write("Enter Length of a room in feet:");
        length = Convert.ToInt32(ReadLine());
        Write("Enter Width of a room in feet:");
        width = Convert.ToInt32(ReadLine());
        paintingCost = ComputerCost(length, width);
        WriteLine("The cost of painting the room height {0}, width {1}. Painting cost is: {2}", 
        length, width, paintingCost.ToString("C"));
    }

    public static double ComputerCost(int length, int width)
    {
        const int height = 9;
        const int costPerSquareFoot = 6;
        double price = (length * height * 2 + width * height * 2) * costPerSquareFoot;
        return price;
    }

    
}

