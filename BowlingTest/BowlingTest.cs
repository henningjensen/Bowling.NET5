using Xunit;

namespace BowlingTest
{
    public class BowlingTest
    {
        private Bowling bowling;
        
        public BowlingTest() {
            bowling = new Bowling();
        }
        
        [Fact]
        public void AlleKastIRenna()
        {
            KastMange(20, 0);
            Assert.Equal(0, bowling.Poeng());
        }
        
        private void KastMange(int antall, int pinner) {
            for(int i = 0; i < antall; i++) {
                bowling.Kast(pinner);
            }
        }
        
        [Fact]
        public void AllKastMed1Poeng() {
            KastMange(20, 1);
            Assert.Equal(20, bowling.Poeng());
        }
        
        [Fact]
        public void OneSpare() {
            bowling.Kast(5);
            bowling.Kast(5);
            bowling.Kast(3);
            KastMange(17,0);
            Assert.Equal(16, bowling.Poeng());
        }
    }
}
