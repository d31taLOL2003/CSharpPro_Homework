namespace Second_Homework.Second_Task
{
    public class Cello : MusicalInstrument
    {
        public Cello() : base("Cello", "A bass string instrument with a wide tonal range.") { }

        public override void Sound()
        {
            Console.WriteLine("Sound: The cello sings with a rich, warm tone that can fill a concert hall.");
        }

        public override void History()
        {
            Console.WriteLine("History: The cello's design was finalized in the early 16th century and became a mainstay in classical music.");
        }
    }
}
