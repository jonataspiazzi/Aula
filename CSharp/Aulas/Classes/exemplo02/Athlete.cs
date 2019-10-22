namespace exemplo02
{
    public class Athlete
    {
        public string Name;

        public int Age;

        public Competition[] Competitions;

        public int CalcTotalPoints()
        {
            var total = 0;

            foreach (var c in this.Competitions)
            {
                if (c.Time < 10)
                {
                    total += 100;
                }
                else if (c.Time < 13)
                {
                    total += 70;
                }
                else {
                    total += 40;
                }
            }

            return total;
        }
    }
}