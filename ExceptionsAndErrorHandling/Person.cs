namespace ExceptionsAndErrorHandling
{
    public class Person
    {
        public string Name { get; }
        public int YearOfBirth { get; }

        public Person(string name, int yearOfBirth)
        {
            if (name == string.Empty)
            {
                throw new ArgumentException("Name cannot be empty",
                    nameof(name));
            }

            if (yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year)
            {
                throw new AggregateException("Invalid year of birth");
            }
        }
    }
}