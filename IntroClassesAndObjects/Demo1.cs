
namespace IntroClassesAndObjects
{
    internal class Demo1
    {
        public static void Run()
        {
            /* Variant 1 i JS:
 let myTextObject = {
   text: 'Terje',
   col: 10,
   row: 3,
 }
 */

            var myTextObject = new TextObject()
            {
                Text = "Terje",
                Col = 10,
                Row = 3
            };

/*
 Variant 2: JS
   let myTextObject = {};
   myTextObject.text = 'Terje';
   myTextObject.col = 10;
   myTextObject.row = 3;
 */
            var myTextObject2 = new TextObject();
            myTextObject.Text = "Terje";
            myTextObject.Col = 10;
            myTextObject.Row = 3;

            Console.WriteLine("Hello, World!");
        }
    }
}
