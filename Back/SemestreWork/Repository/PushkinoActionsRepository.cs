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
    public class PushkinoActionsRepository : IPushkinoActionsRepository
    {
        IConfiguration _configuration;

        public PushkinoActionsRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public int Add(PushkinoActionPost news)
        {
            var connectionString = this.GetConnection();
            int count = 0;
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "INSERT INTO PushkinoActionsPosts(Name, Intro, Text, Picture) VALUES(@Name, @Intro, @Text,@Picture);";
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
                    var query = "DELETE FROM PushkinoActionsPosts WHERE Id =" + id;
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

        public int EditNews(PushkinoActionPost news)
        {
            var connectionString = this.GetConnection();
            var count = 0;

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "UPDATE PushkinoActionsPosts SET Name = @Name, Intro = @Intro, Text = @Text, Picture = @Picture WHERE Id = @Id";
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

        public List<PushkinoActionPost> GetList()
        {
            var connectionString = this.GetConnection();
            List<PushkinoActionPost> products = new List<PushkinoActionPost>();

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "SELECT * FROM PushkinoActionsPosts ORDER BY Id";
                    products = con.Query<PushkinoActionPost>(query).ToList();
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

        public PushkinoActionPost GetNews(int id)
        {
            var connectionString = this.GetConnection();
            PushkinoActionPost product = new PushkinoActionPost();

            using (var con = new SqlConnection(connectionString))
            {
                try
                {

                    con.Open();
                    var query = "SELECT * FROM PushkinoActionsPosts WHERE Id =" + id;
                    product = con.Query<PushkinoActionPost>(query).FirstOrDefault();
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