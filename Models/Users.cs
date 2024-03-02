namespace CtlbasedTodoApi.Models
{
    public class Users
    {
        public long Id { get; set; }    
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}
