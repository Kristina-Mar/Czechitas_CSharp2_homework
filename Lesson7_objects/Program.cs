namespace Lesson7_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<GraphicObject> graphicObjects = new List<GraphicObject>()
            { 
                new Rectangle(5, 3, "Red"),
                new Triangle(5, "eggshell"), // Invalid colour on purpose.
                new Text("hellooo", "Blue") 
            };
            
            //graphicObjects.ForEach(o => o.PrintToConsole());

            foreach (var o in graphicObjects)
            {
                o.PrintToConsole();
                Console.WriteLine();
            }
        }
    }
}
