namespace ChallengeApp
{
    public class User
    { // zmienna statyczna
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
}
