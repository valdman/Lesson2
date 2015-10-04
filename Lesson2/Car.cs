namespace Lesson2
{
    class Car
    {
        public Car(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public string GetName() { return _name; }
        public string GetDescription() { return _description; }
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
