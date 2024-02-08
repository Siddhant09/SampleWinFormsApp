namespace WinFormsApp.EFModels;

public partial class User
{
    public long UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateOnly BirthDay { get; set; }

    public long? ColorId { get; set; }

    public bool Married { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? SubmitDate { get; set; }

    public virtual Color? Color { get; set; }
}
