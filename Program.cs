using Npgsql;
using System;
using System.Threading.Tasks;

Console.WriteLine("🔌 Probando conexión con Supabase (Session Pooler IPv4)...");

// Reemplazá TU_PASSWORD por la real
var connectionString = "Host=aws-0-sa-east-1.pooler.supabase.com;Port=5432;Database=postgres;Username=postgres.cifhzukobpkvlqsyqrka;Password=postgres;SSL Mode=Require";

try
{
    using var conn = new NpgsqlConnection(connectionString);
    await conn.OpenAsync();
    Console.WriteLine("✅ Conexión exitosa a Supabase usando Session Pooler.");
}
catch (Exception ex)
{
    Console.WriteLine($"❌ Error al conectar: {ex.Message}");
}
