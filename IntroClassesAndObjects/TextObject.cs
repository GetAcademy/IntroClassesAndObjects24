namespace IntroClassesAndObjects
{
    class TextObject
    {
        public string Text;
        public int Col;
        public int Row;
    }

    class Model
    {
        public App App;
        public int Counter;
        public string CurrentPage;
        public TextObject[] MyTextObjects;
    }

    class App
    {
        public string LoggedInUser;
    }
}
