namespace IntroClassesAndObjects
{
    internal class Demo4
    {
        public static void Run()
        {
            /*
             let search = {
                text: 'terje',
                dates: {
                    includeFromAndTo: true,
                    from: {
                        day: 10,
                        month: 5,
                        year: 2023,
                    },
                    to: {
                        day: 10,
                        month: 5,
                        year: 2023,
                    },
                }
             }
             */

            var search = new Search
            {
                Text = "terje",
                Dates = new DateFilter
                {
                    IncludeFromAndTo = true,
                    From = new Date
                    {
                        Day = 10,
                        Month = 5,
                        Year = 2023,
                    },
                    To = new Date
                    {
                        Day = 10,
                        Month = 5,
                        Year = 2023,
                    },
                }
            };
        }
    }
}
