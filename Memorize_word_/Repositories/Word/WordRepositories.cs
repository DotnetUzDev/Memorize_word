using EduCenter.Desktop.Constants;
using Memorize_word_.Entities.WordEntities;
using Memorize_word_.Interfase.WordRep;
using Memorize_word_.Utils;
using Npgsql;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Memorize_word_.Repositories.Word;

public class WordRepositories : IWordRepositories
{
    private readonly NpgsqlConnection _connection;

    public WordRepositories()
    {
        _connection = new NpgsqlConnection(DbConstants.DB_CONNECTIONSTRING);
    }
    public Task<int> CountAsync()
    {
        throw new System.NotImplementedException();
    }

    public async Task<int> CreateAsync(Words obj)
    {
        //try
        //{

        //    }
        //}
        //catch
        //{
        //    return 0;
        //}
        //finally
        //{
        //    await _connection.CloseAsync();
        //}
        await _connection.OpenAsync();

        string query = "INSERT INTO word(" +
            "word,example,describtion,image1,image2,image3,created_at,updated_at,translate)" +
            "VALUES (@word,@example,@describtion,@image1,@image2,@image3,@created_at,@updated_at,@translate);";
        await using (var command = new NpgsqlCommand(query, _connection))
        {
            command.Parameters.AddWithValue("Word", obj.Word);
            command.Parameters.AddWithValue("example", obj.example);
            command.Parameters.AddWithValue("describtion", obj.describtion);
            command.Parameters.AddWithValue("image1", obj.image1);
            command.Parameters.AddWithValue("image2", obj.image2);
            command.Parameters.AddWithValue("image3", obj.image3);
            command.Parameters.AddWithValue("created_at", obj.CreatedAt);
            command.Parameters.AddWithValue("updated_at", obj.UpdatedAt);
            command.Parameters.AddWithValue("translate", obj.translate);

            var dbResult = await command.ExecuteNonQueryAsync();
            return dbResult;
            await _connection.CloseAsync();
        }
    }

    public async Task<int> DeleteAsync(long id)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"DELETE FROM public.\"word\" WHERE \"id\"={id};";
            await using (var command = new NpgsqlCommand(query, _connection))
            {
                int natija = await command.ExecuteNonQueryAsync();
                return natija;
            }
        }
        catch
        {

            return 0;
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    

    public async Task<IList<Words>> GetAllAsync(PaginationParams @params)
    {
        try
        {
            await _connection.OpenAsync();
            var list = new List<Words>();
            string query = $"SELECT * FROM WORD order by id " +
                $"offset {(@params.PageNumber - 1) * @params.PageSize} " +
                $"limit {@params.PageSize}";

            await using (var command = new NpgsqlCommand(query, _connection))
            {
                await using (var reader = command.ExecuteReader())
                {
                    while(await reader.ReadAsync())
                    {
                        var word = new Words();
                        word.id = reader.GetInt64(0);
                        word.Word = reader.GetString(1);
                        word.example = reader.GetString(2);
                        word.describtion = reader.GetString(3);
                        word.image1 = reader.GetString(4);
                        word.image2 = reader.GetString(5);
                        word.image3 = reader.GetString(6);
                        word.CreatedAt = reader.GetDateTime(7);
                        word.UpdatedAt = reader.GetDateTime(8);
                        word.translate = reader.GetString(9);

                        list.Add(word);
                    }
                }
            }
            return list;
        }
        catch
        {
            return new List<Words>();
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public Task<Words> GetAsync(long id)
    {
        throw new System.NotImplementedException();
    }

    public Task<int> UpdateAsync(long id, Words editedObj)
    {
        throw new System.NotImplementedException();
    }
}
