// See https://aka.ms/new-console-template for more information
using Calculator;
var c = new MathCal();

while (true)
{
    int x=0, y=0;
    Console.WriteLine("press enter to start :");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Choose operation:\n1.Add\n2.Subract\n3.Multiply\n4.Divide ");
    int s = Int32.Parse(Console.ReadLine());
    if (s != 1)
    {
        Console.Write("enter operands:\nn1 = ");
        x = Int32.Parse(Console.ReadLine());
        Console.Write("n2 = ");
        y = Int32.Parse(Console.ReadLine());
    }
    



    switch (s)
    {
        case (1):
            Console.WriteLine("Enter space separated numbers");
            String[] r=(Console.ReadLine().Split(" "));
            try
            {
                int[] a = Array.ConvertAll(r, int.Parse);
                Console.WriteLine(c.add(a));
            }
            catch
            {
                Console.WriteLine("Numbers too big");
            }
            break;
        case (2):
            Console.WriteLine(c.sub(x, y)); break;
        case (3):
            Console.WriteLine(c.mul(x, y)); break;
        case (4):
            Console.WriteLine(c.div(x, y)); break;
        case (5):
            Console.WriteLine(c.mod(x, y)); break;
        default: Console.WriteLine("Invalid operator"); break;
    }

}