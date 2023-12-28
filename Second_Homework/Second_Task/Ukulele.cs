namespace Second_Homework.Second_Task
{
    public class Ukulele : MusicalInstrument
    {
        public Ukulele() : base("Ukulele", "A small four-stringed guitar of Hawaiian origin.") { }

        public override void Sound()
        {
            Console.WriteLine("Sound: The ukulele produces a bright, cheerful sound.");
        }

        public override void History()
        {
            Console.WriteLine("History: The ukulele was popularized in Hawaii in the 19th century, adapting from the Portuguese machete.");
        }
    }
}
