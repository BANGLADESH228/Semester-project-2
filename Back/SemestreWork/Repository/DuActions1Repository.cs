using Dapper;

using Microsoft.Extensions.Configuration;
using SemestreWork.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SemestreWork.Repository
{
    public class DuActions1Repository : IDuActions1Repository
    {
        IConfiguration _configuration;

        public DuActions1Repository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public int Add(DuActionsPost news)
        {
            var connectionString = this.GetConnection();
            int count = 0;
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "INSERT INTO DuActionsPosts(Name, Intro, Text, Picture) VALUES(@Name, @Intro, @Text,@Picture);";
                    count = con.Execute(query, news);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return count;
            }
        }

        public int DeleteNews(int id)
        {
            var connectionString = this.GetConnection();
            var count = 0;

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "DELETE FROM DuActionsPosts WHERE Id =" + id;
                    count = con.Execute(query);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return count;
            }
        }

        public int EditNews(DuActionsPost news)
        {
            var connectionString = this.GetConnection();
            var count = 0;

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "UPDATE DuActionsPosts SET Name = @Name, Intro = @Intro, Text = @Text, Picture = @Picture WHERE Id = @Id";
                    count = con.Execute(query, news);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return count;
            }
        }

        public List<DuActionsPost> GetList()
        {
            var connectionString = this.GetConnection();
            List<DuActionsPost> products = new List<DuActionsPost>();

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "SELECT * FROM DuActionsPosts ORDER BY Id";
                    products = con.Query<DuActionsPost>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

                return products;
            }
        }

        public DuActionsPost GetNews(int id)
        {
            var connectionString = this.GetConnection();
            DuActionsPost product = new DuActionsPost();

            using (var con = new SqlConnection(connectionString))
            {
                try
                {

                    con.Open();
                    var query = "SELECT * FROM DuActionsPosts WHERE Id =" + id;
                    product = con.Query<DuActionsPost>(query).FirstOrDefault();
                }
                catch
                {
                    throw new Exception("Нет данного поста");
                }
                finally
                {
                    con.Close();
                }

                return product;
            }
        }

        public string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings").GetSection("MyData").Value;
            return connection;
        }
    }
}