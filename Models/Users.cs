namespace Help_Desk_Log_API.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool  IsDeleted { get; set; }

    }
}
