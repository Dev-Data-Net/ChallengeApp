User user1 = new User("Stanisław", "3434fdsefd");
User user2 = new User("Mieczysław", "f342dfdsff");
User user3 = new User("Mirosław", "dsfsarw34344");
User user4 = new User("Lesław", "dsfsfsfsdf34344");

var name = user1.Login;

class User
{
    // pola w klasach

    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
    }
    public string Login { get; private set; }
    public string Password { get; private set; }
}
