using EduCenter.Desktop.Constants;
using Npgsql;

namespace Memorize_word_.Repositories;

public abstract class BaseRepositories
{
    protected readonly NpgsqlConnection _connection;
    public BaseRepositories()
    {
        _connection = new NpgsqlConnection(DbConstants.DB_CONNECTIONSTRING);
    }
}
