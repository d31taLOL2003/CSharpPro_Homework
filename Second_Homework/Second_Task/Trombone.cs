namespace Second_Homework.Second_Task
{
    public class Trombone : MusicalInstrument
    {
        public Trombone() : base("Trombone", "A brass instrument known for its sliding pitch mechanism.") { }

        public override void Sound()
        {
            Console.WriteLine("Sound: The trombone bellows with a rich, deep sound.");
        }

        public override void History()
        {
            Console.WriteLine("History: The trombone has been a pivotal part of orchestral music since the 15th century.");
        }
    }
}
