namespace Sample.Core.Dtos.Requests
{
  public class PersonRequest
    {
      public required int Id { get; set; }

      public string FirstName { get; set; } = string.Empty;

      public string LastName { get; set; } = string.Empty;
    }
}