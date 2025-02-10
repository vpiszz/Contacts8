using SQLite;
namespace Contacts.Models 
{ 
    public class Contact
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
    }
}


public class Contact
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Phone { get; set; }
    public required string Email { get; set; }

    public override string ToString()
    {
        return $"Name:{Name}\nPhone:{Phone}\nEmail:{Email}";
    }
}