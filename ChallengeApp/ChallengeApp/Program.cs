User user1 = new User("Stanisław", "3434fdsefd");
User user2 = new User("Mieczysław", "f342dfdsff");
User user3 = new User("Mirosław", "dsfsarw34344");
User user4 = new User("Lesław", "dsfsfsfsdf34344");

user1.AddScore(5);

class User
{
    private int score;

    // konstruktor
    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
        this.score = 0;
    }

    // pola w klasach
    public string Login { get; private set; }
    public string Password { get; private set; }


    //metody
    public void AddScore(int score)
    {
        this.score += score;
    }
}
