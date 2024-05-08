User user1 = new User("Stanisław", "3434fdsefd");
User user2 = new User("Mieczysław", "f342dfdsff");
User user3 = new User("Mirosław", "dsfsarw34344");
User user4 = new User("Lesław", "dsfsfsfsdf34344");

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);
var name = User.GameName;
var pi = Math.PI;

class User
{
    // zmienna statyczna
    public static string GameName = "Diablo";

    private List<int> score = new List<int>();

    // konstruktor
    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
    }

    // pola w klasach
    public string Login { get; private set; }
    public string Password { get; private set; }

    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }


    //metody
    public void AddScore(int score)
    {
        this.score.Add(score);
    }
}
