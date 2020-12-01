using System;

namespace Variables_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, eyes, teeth, hair;
            int age, height, weight;

            name = "John Smith";
            age = 35;     // not a lie
            height = 74;  // inches
            weight = 180; // lbs
            eyes = "Brown";
            teeth = "White";
            hair = "Brown";

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + height + " inches or (" + (height * 2.54) + " cm) tall.");
            Console.WriteLine("He's " + weight + " pounds or (" + (weight / 2.2) + " kg) heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            // This line is tricky; try to get it exactly right.
            Console.WriteLine("If I add " + age + ", " + height + ", and " + weight + " I get " + (age + height + weight) + ".");

            Console.ReadLine();

        }
    }
}
