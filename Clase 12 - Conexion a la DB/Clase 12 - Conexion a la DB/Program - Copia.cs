public class ProductoHandler
{
    public const string ConnectionString = "Server=tcp:10.108.30.15;" +
        "Database=SistemaGestion;" +
        "Trusted_Connection=True" +
        "User ID=testuser" +
        "Password=qwertu";

    SqlConnection sqlConnection = new SqlConnection(ConnectionString);

}