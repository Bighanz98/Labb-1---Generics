namespace Labb_1___Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxCollection boxList = new BoxCollection();

            boxList.Add(new Box(1, 2, 3));
            boxList.Add(new Box(2, 3, 4));
            boxList.Add(new Box(3, 4, 5));
            boxList.Add(new Box(4, 5, 6));
            boxList.Add(new Box(5, 6, 7));


            //Add a new Box and see if it already exists.
            boxList.Add(new Box(5, 6, 7));

            //Remove a Box from the list.
            boxList.Remove(new Box (2,3,4));
  
            Display(boxList);

            // 4. Check if there is a specific Box in the collection, returns true if it is found, false if it's not.
            Console.WriteLine("-----------------------------");
            Box specificBox = new Box(3, 4, 5);
            Console.WriteLine("\nContains specific box: " + boxList.Contains(specificBox));

            //// 5. Loop all the objects in the collection.
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\nAll the boxes:");
            Display(boxList);

            Console.ReadKey();
        }

        public static void Display(BoxCollection boxes)
        {
          

            foreach (Box box in boxes )
            {
                Console.WriteLine("\t{0}\t{1}\t{2}",
                box.Height.ToString(), box.Lenght.ToString(), box.Width.ToString());
            }
        }
    }
}