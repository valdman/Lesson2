namespace Lesson2
{
    class Car
    {
        public Car(string Name, string Description)
        {
            _name = Name;
            _description = Description;
        }

        public string Name { get { return _name; } }
        public string Description { get { return _description; } }

        public override string ToString()
        {
            return _name;
        }

        protected string _name;
        protected string _description;
    }
}
