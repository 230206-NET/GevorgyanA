namespace DataAccess;

internal class Secrets {
    private const string _connection = "Server=tcp:workoutdb-server-artur.database.windows.net,1433;Initial Catalog=WorkoutDB;Persist Security Info=False;User ID=artur;Password=Revature!999;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

    public static string getConnectionString() => _connection;

}