namespace StudentRecords
{
    public class Student
    {
        private int _id = 0; // Default value for int
        private string _name = string.Empty; // ""
    

     public int Id
        {
            get => _id;
            set
            {
                if (value <= 0)
                
                    throw new ArgumentException("Id must be a positive number.");
                    _id = value;
                
            }
        }
    

        
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

        public Student(int id, string name)
        {
            Id = id; // This will invoke the setter and validate the value
            Name = name; // This will invoke the setter and validate the value
        }

       
    }
}