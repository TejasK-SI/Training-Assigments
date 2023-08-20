namespace ShapeHierarchy_Assgn3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5.7);
            circle.DisplayDetails();

            Rectangle rectangle = new Rectangle(3.5, 2.1);
            rectangle.DisplayDetails();

            Triangle triangle = new Triangle(2,3,4);
            triangle.DisplayDetails();
        }
    }
}