namespace WinFormsApp.EFModels;

public partial class Color
{
    public long ColorId { get; set; }

    public string ColorName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
