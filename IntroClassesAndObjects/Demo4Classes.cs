namespace IntroClassesAndObjects
{
    class Search
    {
        public string Text;
        public DateFilter Dates;
    }

    class DateFilter
    {
        public bool IncludeFromAndTo;
        public Date From;
        public Date To;
    }

    class Date
    {
        public int Day;
        public int Month;
        public int Year;
    }
}
