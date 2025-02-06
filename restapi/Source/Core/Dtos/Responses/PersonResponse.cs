namespace Sample.Core.Dtos.Responses
{
  public class PersonResponse
    {
      public required int Id { get; set; }

      public string FirstName { get; set; } = string.Empty;

      public string LastName { get; set; } = string.Empty;
    }
}