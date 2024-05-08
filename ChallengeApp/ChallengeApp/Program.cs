using ChallengeApp;

User user1 = new User("Stanisław", "3434fdsefd");
User user2 = new User("Mieczysław", "f342dfdsff");
User user3 = new User("Mirosław", "dsfsarw34344");
User user4 = new User("Lesław", "dsfsfsfsdf34344");

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);



