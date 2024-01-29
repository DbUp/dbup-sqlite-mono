using System;
using System.IO;
using Mono.Data.Sqlite;
using Xunit;

namespace DbUp.SQLite.Tests
{
    public class SQLiteSupportTests
    {
        static readonly string dbFilePath = Path.Combine(Environment.CurrentDirectory, "test.db");

        [Fact]
        public void CanUseSQLite()
        {
            var connectionString = string.Format("Data Source={0}; Version=3;", dbFilePath);

            if (!File.Exists(dbFilePath))
            {
                SqliteConnection.CreateFile(dbFilePath);
            }

            var upgrader = DeployChanges.To
                .SQLiteDatabase(connectionString)
                .WithScript("Script0001", "CREATE TABLE IF NOT EXISTS Foo (Id int)")
                .Build();
        }
    }
}
