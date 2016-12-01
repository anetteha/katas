using System;

namespace CRUDingAConsole.Guys
{
    public class Guy
    {
        public int Goodness { get; private set; }
        public int Badness { get; private set; }

        public Guy()
        {
            var random = new Random();
            Goodness = random.Next(1, 10);

            Badness = random.Next(1, 10);
        }

        public Guy(int goodness, int badness)
        {
            if (goodness > 10 && badness > 10)
                throw new ArgumentOutOfRangeException();

            Goodness = goodness;
            Badness = badness;
        }

        public Guid Id { get; set; }

        public void DoGoodDeed()
        {
            this.Goodness++;
        }
    }
}
