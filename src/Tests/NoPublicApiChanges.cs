using DbUp.Tests.Common;

namespace DbUp.SQLite.Tests;

public class NoPublicApiChanges : NoPublicApiChangesBase
{
    public NoPublicApiChanges()
        : base(typeof(SQLiteExtensions).Assembly)
    {
    }
}
