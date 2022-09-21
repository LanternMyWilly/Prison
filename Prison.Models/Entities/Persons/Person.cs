namespace Prison.Models.Entities.Persons;

public class Person : BaseAuditableEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DoB { get; set; }
    public string SocialSecurityNr { get; set; }
    
    public Guid GenderId { get; set; }
    public virtual Gender.Gender Gender  { get; set; }
}