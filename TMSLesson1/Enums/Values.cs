namespace TMSLesson1.Enums
{
    public static class Values
    {
        public enum HourCost
        {
            Intern = 5,
            FirstCategory = 15,
            HighestCategory = 20,
            Professor = 35
        }

        public static Dictionary<int, string> qualifications = new Dictionary<int, string>()
        {
            [1] = "Intern",
            [2] = "First category",
            [3] = "Highest category",
            [4] = "Professor"
        };
    }
}
