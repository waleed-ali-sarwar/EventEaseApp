using System.ComponentModel.DataAnnotations;

public class RegistrationForm
{
    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email address.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Event ID is required.")]
    public int EventId { get; set; }
}

// The Registration class is a simple class with properties that represent the columns in the Registrations table.