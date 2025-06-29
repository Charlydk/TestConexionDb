using Npgsql;
using System;
using System.Net.Sockets;
using System.Threading.Tasks;

Console.WriteLine("🔌 Probando conexión forzada a IPv4...");

var csb = new NpgsqlConnectionStringBuilder
{
    Host = "db.cifhzukobpkvlqsyqrka.supabase.co",
    Port = 5432,
    Database = "postgres",
    Username = "postgres",
    Password = "postgres",
    SslMode = SslMode.Require,
    TrustServerCertificate = true
};

// Creamos la conexión y le asignamos un socket IPv4
var conn = new NpgsqlConnection(csb.ToString())
{
    SocketFactory = af => new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
};

try
{
    await conn.OpenAsync();
    Console.WriteLine("✅ Conexión forzada a IPv4 exitosa.");
}
catch (Exception ex)
{
    Console.WriteLine($"❌ Error al conectar usando IPv4: {ex.Message}");
}

