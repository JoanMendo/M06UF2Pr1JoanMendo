using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using Classes;
using Npgsql;

namespace Conection;

public class CloudConnection
{
    private String HOST = "127.0.0.1:5432"; // Ubicació de la BD.
    private String DB = "training"; // Nom de la BD.
    private String USER = "traininga";
    private String PASSWORD = "training";

    public NpgsqlConnection GetConnection()
    {
        NpgsqlConnection conn = new NpgsqlConnection(
            "Host=" + HOST + ";" + "Username=" + USER + ";" +
            "Password=" + PASSWORD + ";" + "Database=" + DB + ";"
        );
        conn.Open();
        return conn;
    }
}



