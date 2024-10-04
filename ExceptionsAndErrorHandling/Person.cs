namespace ExceptionsAndErrorHandling
{
    public class Person
    {
        public string Name { get; }
        public int YearOfBirth { get; }

        public Person(string name, int yearOfBirth)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (name == string.Empty)
            {
                throw new ArgumentException("Name cannot be empty",
                    nameof(name));
            }

            if (yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year)
            {
                throw new ArgumentOutOfRangeException("Invalid year of birth");
            }
        }
    }
}