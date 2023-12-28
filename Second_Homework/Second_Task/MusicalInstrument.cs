namespace Second_Homework.Second_Task
{
    public class MusicalInstrument
    {
        protected string _name;
        protected string _description;

        public MusicalInstrument(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public virtual void Sound()
        {
            Console.WriteLine($"{_name} makes a sound");
        }

        public virtual void Show()
        {
            Console.WriteLine($"Instrument: {_name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine($"Description: {_description}");
        }

        public virtual void History()
        {
            Console.WriteLine($"History of the {_name}");
        }
    }
}
