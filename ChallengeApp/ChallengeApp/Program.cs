User user1 = new User();
User user2 = new User("Mieczysław", "");
User user3 = new User("Mirosław");



class User
{
    private string login;
    private string password;
    private string name;


    // konstruktory
    public User()
    {
        this.login = "-";
        this.password = "-";
        this.name = "-";
    }
    public User(string login)
    {
        this.login = login;
        this.password = "-";
        this.name = "-";
    }

    public User(string login, string password)
    {
        this.login = login;
        this.password = password;
        this.name = "-";
    }
    public User(string login, string password, string name)
    {
        this.login = login;
        this.password = password;
        this.name = name;
    }
}
