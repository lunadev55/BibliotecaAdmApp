using System;
using System.Collections.Generic;
using System.Text;
using BibliotecaAdmApp.Application.Interfaces;
using BibliotecaAdmApp.Core.Entities;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Threading.Tasks;
using System.Net;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BibliotecaAdmApp.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IConfiguration _configuration;

        public BookRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<int> Add(Core.Entities.Book entity)
        {

            var status_aux = "'Disponivel'";

            if (entity.Status == Core.Enums.BookStatus.Indisponivel)
            {
                status_aux = "'Indisponivel'";
            }          
            
            string script = @"INSERT INTO Books (Category, Name, Author, Pages, Status)
                            Values (@Category, @Name, @Author, @Pages, " + status_aux + @");";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var response = await connection.ExecuteAsync(script, entity);
                connection.Close();
                return response;
            }
        }

        public async Task<int> Delete(int id)
        {
            string script = @"DELETE FROM Books WHERE Id = @Id;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var response = await connection.ExecuteAsync(script, new { Id = id });
                connection.Close();
                return response;
            }
        }

        public async Task<Book> Get(int id)
        {
            string script = @"SELECT * FROM Books WHERE Id = @Id;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var response = await connection.QueryAsync<Book>(script, new { Id = id });
                connection.Close();
                return response.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<Book>> FindAll()
        {
            string script = @"SELECT * FROM Books;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var books = await connection.QueryAsync<Book>(script);
                connection.Close();
                return books;
            }
        }

        public async Task<int> Update(Core.Entities.Book entity)
        {
            var id = entity.Id;

            var status_aux = "'Disponivel'";

            if (entity.Status == Core.Enums.BookStatus.Indisponivel)
            {
                status_aux = "'Indisponivel'";
            }

            string script = @"UPDATE Books SET Category = @Category, Name = @Name, Author = @Author,
                              Pages = @Pages, Status = " + status_aux + " WHERE Id = " + id + ";";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(script, entity);
                connection.Close();
                return result;
            }
        }        

    }
}
