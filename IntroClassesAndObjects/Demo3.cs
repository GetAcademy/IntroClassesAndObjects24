namespace IntroClassesAndObjects
{
    internal class Demo3
    {
        public static void Run()
        {
            /* Variant 1 i JS:
              const model = {
                 app: {
                    loggedInUser: 'terje',
                 },
                 counter: 5,
                 currentPage: 'main',
                 myTextObjects: [
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
              };
            */
            var model0 = new Model();
            var model = new Model
            {
                App = new App
                {
                    LoggedInUser = "terje",
                },
                Counter = 5,
                CurrentPage = "main",
                MyTextObjects = new TextObject[]
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
                }
            };
        }
    }
}
