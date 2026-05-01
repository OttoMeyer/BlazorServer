namespace BlazorTestApp.UserDataTypes;

public class UserInformation{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public DateOnly LastLogin { get; set; }
    public string? Status { get; set; }
};

public class TestType
{
    public int Id { get; set; }
    public string? Name { get; set; }
}