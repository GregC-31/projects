namespace StudentRecords
{
    public class Course
    {

         public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be null or empty.");

                _name = value;
            }
        }

        public string Code
        {
            get => _code;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Code cannot be null or empty.");

                _code = value;
            }
        }

        public Course(string Code)
        {
            Id = id; // This will invoke the setter and validate the value
        

       
    }
}