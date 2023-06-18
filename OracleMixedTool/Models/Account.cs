namespace OracleMixedTool.Models
{
    public class Account
    {
        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public int PasswordIndex { get; set; } = 1;

        public string NewpassWord { get; set; } = null!;

        public List<string> ToBeDeleteInstances { get; set; } = new();

        public string ToBeCreateInstance { get; set; } = null!;
    }
}
