namespace Second_Homework.Second_Task
{
    public class Violin : MusicalInstrument
    {
        public Violin() : base("Violin", "A string instrument usually with four strings tuned in perfect fifths.") { }

        public override void Sound()
        {
            Console.WriteLine("Sound: Violin makes a classic and elegant sound.");
        }

        public override void History()
        {
            Console.WriteLine("History: The violin first emerged in 16th-century Italy.");
        }
    }
}
