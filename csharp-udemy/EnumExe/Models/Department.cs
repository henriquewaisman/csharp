namespace EnumExe.Models
{
    public class Department
    {
        public string Name { get; protected set; }

        public void SetName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Name can not be empty.");
            }
            if(name.Length > 255)
            {
                throw new Exception("Department name length can not be greater than 255 characters.");
            }
            Name = name;
        }
    }
}