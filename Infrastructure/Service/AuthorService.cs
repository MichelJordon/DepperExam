using Dapper;
using Domain.Dtos;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class AuthorService
    {
        private string _connectionString = "Server=127.0.0.1;Port=5432;Database=quote_service;User Id=postgres;Password=shohrukh;";

        public List<Author> GetAuthors()
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"SELECT * FROM Authors";

                return conn.Query<Author>(sql).ToList();
            }
        }

        public int InsertAuthor(Author author)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql =
                    $"insert into Authors (QuoteText) VALUES " +
                    $"('{author.QuoteText}')";
                var result = conn.Execute(sql);

                return result;
            }
        }

        public int UpdateAuthor(Author author)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                string sql = $"Update Authors Set quotetext = '{author.QuoteText}', CategoryId = {author.CategoryId} where id = {author.Id}";
            
                var result = conn.Execute(sql);

                return result;
            }
        }
        public List<Author> GetRendomQuotes()
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"Select * from Authors Order by random() limit 1;";
            
                var result = conn.Execute(sql);

                return result;
            }
        }
        public int DeleteAuthor(int id)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"DELETE FROM Authors WHERE id = {id}";

                var result = conn.Execute(sql);

                return result;
            }
        }

    }
}