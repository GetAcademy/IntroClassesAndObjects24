namespace IntroClassesAndObjects
{
    class TextObject
    {
        public string Text;
        public int Col;
        public int Row;
        public int SpeedCol;
        public int SpeedRow;

        public TextObject()
        {
        }

        public TextObject(
            string text, int col, 
            int row, int speedCol, int speedRow)
        {
            Text = text;
            Col = col;
            Row = row;
            SpeedCol = speedCol;
            SpeedRow = speedRow;
        }

        public void Move()
        {
            Col += SpeedCol;
            Row += SpeedRow;
        }

        public void Show()
        {
            Console.CursorLeft = Col;
            Console.CursorTop = Row;
            Console.WriteLine(Text);
        }
    }
}
