namespace BowlingTest
{
    public class Bowling
    {
        private int poeng = 0;
        
        public void Kast(int r)
        {
            poeng += r;
        }

        public int Poeng()
        {
            return poeng;
        }
    }
}

