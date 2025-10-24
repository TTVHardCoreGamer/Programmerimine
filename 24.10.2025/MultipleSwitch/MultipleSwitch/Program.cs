namespace MultipleSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple cases");

            string topic, category;

            topic = Console.ReadLine();

            switch (topic)
            {
                case "Intro to c#":
                case "Variables":
                case "Data Types":
                    category = "Basics";
                    break;

                case "Loops":
                case "If statements":
                case "Jump statemenents":
                    category = "Control Flow";
                    break;

                case "Class & Objects":
                case "Inheritance":
                case "Constructors":
                    category = "OOP-s Concept";
                    break;

                default:
                    category = "Unknown";
                    break;
            }
        }
    }
}
