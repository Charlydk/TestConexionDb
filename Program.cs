using Npgsql;

Console.WriteLine("🔌 Probando conexión directa a Supabase...");

var connectionString = "Host=db.cifhzukobpkvlqsyqrka.supabase.co;Port=5432;Database=postgres;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true";

try
{
    using var conn = new NpgsqlConnection(connectionString);
    await conn.OpenAsync();
    Console.WriteLine("✅ Conexión exitosa a Supabase.");
}
catch (Exception ex)
{
    Console.WriteLine($"❌ Error al conectar: {ex.Message}");
}
