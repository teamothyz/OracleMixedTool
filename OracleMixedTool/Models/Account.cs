namespace OracleMixedTool.Models
{
    public class Account
    {
        public string Email { get; set; } = null!;

        public string CurrentPassword { get; set; } = null!;

        public string Password { get; set; } = null!;

        public int PasswordIndex { get; set; } = 1;

        public string NewPassword { get; set; } = null!;

        public List<string> ToBeDeleteInstances { get; set; } = new();

        public List<string> ToBeRebootInstances { get; set; } = new();

        public string ToBeCreateInstance { get; set; } = null!;

        public ImgType Image { get; set; } = ImgType.Ampere;

        #region Logs work
        public List<string> DeletedInstances { get; set; } = new();

        public List<string> RebootedInstances { get; set; } = new();

        public List<string> CurrentInstances { get; set; } = new();

        public List<string> Errors { get; set; } = new();
        #endregion
    }
}
