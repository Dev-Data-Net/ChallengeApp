User user1 = new User("Stanisław");
User user2 = new User("Mieczysław");
User user3 = new User("Mirosław");



class User
{
    private string login;
    private string password;
    private string name;

    public User(string login)
    {
        this.login = login;
    }
}
