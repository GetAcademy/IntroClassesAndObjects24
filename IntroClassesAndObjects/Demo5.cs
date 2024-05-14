namespace IntroClassesAndObjects
{
    internal class Demo5
    {
        public static void Run()
        {
            var myTextObjects = new TextObject[]
            {
                new TextObject("Terje", 20, 3, 1, 0),
                new TextObject("Per", 3, 20, 0, 1),
                new TextObject("Pål", 3, 3, 1, 1),
                new TextObject("Espen", 20, 20, 0, 0),
            };

            while (true)
            {
                Console.Clear();
                foreach (var myTextObject in myTextObjects)
                {
                    myTextObject.Show();
                    myTextObject.Move();
                }
                Thread.Sleep(400);
            }

            Console.CursorLeft = 1;
            Console.CursorTop= 15;

        }
    }
}
