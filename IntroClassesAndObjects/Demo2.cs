namespace IntroClassesAndObjects
{
    internal class Demo2
    {
        public static void Run()
        {
            /* Variant 1 i JS:
                 let myTextObjects = [
                    {
                       text: 'Terje',
                       col: 10,
                       row: 3,
                    }, 
                    {
                       text: 'Torje',
                       col: 3,
                       row: 10,
                    }, 
                ];
            */

            TextObject[] myTextObjects = new TextObject[]
            {
                new TextObject()
                {
                    Text = "Terje",
                    Col = 10,
                    Row = 3
                }, 
                new TextObject()
                {
                    Text = "Torje",
                    Col = 3,
                    Row = 10
                }
            };

            var myTextObject = myTextObjects[0];
            Console.WriteLine(myTextObject.Text);


        }
    }
}
