namespace StudentRecords
{
    public class Student
    {
        private int _id;
        private string _name;
    

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

       
    }
}