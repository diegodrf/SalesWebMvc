namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; }
        public string Name { get; }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
