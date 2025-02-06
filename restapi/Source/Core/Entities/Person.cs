namespace Sample.Core.Entities
{
  public class Person
    {
      public required int Id { get; set; }

      public string FirstName { get; set; } = string.Empty;

      public string LastName { get; set; } = string.Empty;
    }
}