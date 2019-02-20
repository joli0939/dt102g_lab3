using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Laboration3.Models
{
    public class MovieMethods
    {

        public MovieMethods() { }

        public int InsertMovie(MovieDetail md, out string errormsg)
        {
            // Skapa sql-anslutning
            SqlConnection dbConnection = new SqlConnection();

            // Koppla mot SQL-server
            dbConnection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Laboration3;Integrated Security=True";

            // SQL-sträng för att lägga till i databasen
            String sqlstring = "INSERT INTO Movie (Name, Genre, Playtime, Year, IMDBScore, Director) VALUES (@name, @genre, @playtime, @year, @imdbscore, @director)";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("name", SqlDbType.NVarChar, 50).Value = md.Name;
            dbCommand.Parameters.Add("genre", SqlDbType.NVarChar, 20).Value = md.Genre;
            dbCommand.Parameters.Add("playtime", SqlDbType.Int).Value = md.Playtime;
            dbCommand.Parameters.Add("year", SqlDbType.Int).Value = md.Year;
            dbCommand.Parameters.Add("imdbscore", SqlDbType.Float).Value = md.IMDBScore;
            dbCommand.Parameters.Add("director", SqlDbType.NVarChar, 50).Value = md.Director;

            try
            {
                dbConnection.Open();
                int i = 0;
                i = dbCommand.ExecuteNonQuery();
                if (i == 1) { errormsg = ""; }
                else { errormsg = "Det lades inte till någon film i databasen"; }
                return (i);
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return 0;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public int DeleteMovie(int deleteId, out string errormsg)
        {
            // Skapa sql-anslutning
            SqlConnection dbConnection = new SqlConnection();

            // Koppla mot SQL-server
            dbConnection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Laboration3;Integrated Security=True";

            // SQL-sträng för att lägga till i databasen
            String sqlstring = "DELETE FROM Movie WHERE Id = @deleteId";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("deleteId", SqlDbType.Int).Value = deleteId;

            try
            {
                dbConnection.Open();
                int i = 0;
                i = dbCommand.ExecuteNonQuery();
                if (i == 1) { errormsg = ""; }
                else { errormsg = "Ingen film togs bort"; }
                return (i);
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return 0;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public List<MovieDetail> GetMovieList (out string errormsg)
        {
            // Skapa sql-anslutning
            SqlConnection dbConnection = new SqlConnection();

            // Koppla mot SQL-server
            dbConnection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Laboration3;Integrated Security=True";

            // SQL-sträng för att lägga till i databasen
            String sqlstring = "SELECT * FROM Movie";

            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            // Skapa en adapter
            SqlDataAdapter myAdapter = new SqlDataAdapter(dbCommand);
            DataSet myDS = new DataSet();

            List<MovieDetail> MovieList = new List<MovieDetail>();

            try
            {
                dbConnection.Open();

                // Fyller dataset
                myAdapter.Fill(myDS, "myMovie");

                int count = 0;
                int i = 0;
                count = myDS.Tables["myMovie"].Rows.Count;

                if (count > 0)
                {
                    while (i < count)
                    {
                        MovieDetail md = new MovieDetail();
                        md.Name = myDS.Tables["myMovie"].Rows[i]["Name"].ToString();
                        md.Genre = myDS.Tables["myMovie"].Rows[i]["Genre"].ToString();
                        md.Playtime = Convert.ToInt32(myDS.Tables["myMovie"].Rows[i]["Playtime"]);
                        md.Year = Convert.ToInt32(myDS.Tables["myMovie"].Rows[i]["Year"]);
                        md.IMDBScore = Convert.ToDouble(myDS.Tables["myMovie"].Rows[i]["IMDBScore"]);
                        md.Director = myDS.Tables["myMovie"].Rows[i]["Director"].ToString();
                        md.Id = Convert.ToInt32(myDS.Tables["myMovie"].Rows[i]["Id"]);

                        i++;
                        MovieList.Add(md);
                    }

                    errormsg = "";
                    return MovieList;
                }
                else
                {
                    errormsg = "Det hämtades inga poster";
                    return (null);
                }
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return null;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public List<MovieDetail> SearchMovie(out string errormsg, string searchQuery)
        {
            // Skapa sql-anslutning
            SqlConnection dbConnection = new SqlConnection();

            // Koppla mot SQL-server
            dbConnection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Laboration3;Integrated Security=True";

            // SQL-sträng för att lägga till i databasen
            String sqlstring = "SELECT * FROM Movie WHERE Name LIKE @searchQuery OR Director LIKE @searchQuery OR Genre LIKE @searchQuery OR Year LIKE @searchQuery";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("searchQuery", SqlDbType.NVarChar, 50).Value = "%" + searchQuery + "%";

            // Skapa en adapter
            SqlDataAdapter myAdapter = new SqlDataAdapter(dbCommand);
            DataSet myDS = new DataSet();

            List<MovieDetail> MovieList = new List<MovieDetail>();

            try
            {
                dbConnection.Open();

                // Fyller dataset
                myAdapter.Fill(myDS, "myMovie");

                int count = 0;
                int i = 0;
                count = myDS.Tables["myMovie"].Rows.Count;

                if (count > 0)
                {
                    while (i < count)
                    {
                        MovieDetail md = new MovieDetail();
                        md.Name = myDS.Tables["myMovie"].Rows[i]["Name"].ToString();
                        md.Genre = myDS.Tables["myMovie"].Rows[i]["Genre"].ToString();
                        md.Playtime = Convert.ToInt32(myDS.Tables["myMovie"].Rows[i]["Playtime"]);
                        md.Year = Convert.ToInt32(myDS.Tables["myMovie"].Rows[i]["Year"]);
                        md.IMDBScore = Convert.ToDouble(myDS.Tables["myMovie"].Rows[i]["IMDBScore"]);
                        md.Director = myDS.Tables["myMovie"].Rows[i]["Director"].ToString();
                        md.Id = Convert.ToInt32(myDS.Tables["myMovie"].Rows[i]["Id"]);

                        i++;
                        MovieList.Add(md);
                    }

                    errormsg = "";
                    return MovieList;
                }
                else
                {
                    errormsg = "Det hämtades inga poster";
                    return (null);
                }
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return null;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public MovieDetail GetMovie(out string errormsg, int movieId)
        {
            // Skapa sql-anslutning
            SqlConnection dbConnection = new SqlConnection();

            // Koppla mot SQL-server
            dbConnection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Laboration3;Integrated Security=True";

            // SQL-sträng för att lägga till i databasen
            String sqlstring = "SELECT * FROM Movie WHERE Id = @movieId";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("movieId", SqlDbType.Int).Value = movieId;

            // Skapa en adapter
            SqlDataAdapter myAdapter = new SqlDataAdapter(dbCommand);
            DataSet myDS = new DataSet();

            MovieDetail Movie = new MovieDetail();

            try
            {
                dbConnection.Open();

                // Fyller dataset
                myAdapter.Fill(myDS, "myMovie");

                int count = 0;
                int i = 0;
                count = myDS.Tables["myMovie"].Rows.Count;

                if (count > 0)
                {
                    while (i < count)
                    {
                        MovieDetail md = new MovieDetail();
                        md.Name = myDS.Tables["myMovie"].Rows[i]["Name"].ToString();
                        md.Genre = myDS.Tables["myMovie"].Rows[i]["Genre"].ToString();
                        md.Playtime = Convert.ToInt32(myDS.Tables["myMovie"].Rows[i]["Playtime"]);
                        md.Year = Convert.ToInt32(myDS.Tables["myMovie"].Rows[i]["Year"]);
                        md.IMDBScore = Convert.ToDouble(myDS.Tables["myMovie"].Rows[i]["IMDBScore"]);
                        md.Director = myDS.Tables["myMovie"].Rows[i]["Director"].ToString();
                        md.Id = Convert.ToInt32(myDS.Tables["myMovie"].Rows[i]["Id"]);

                        i++;
                        Movie = md;
                    }

                    errormsg = "";
                    return Movie;
                }
                else
                {
                    errormsg = "Det hämtades inga poster";
                    return (null);
                }
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return null;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public int UpdateMovie(MovieDetail md, out string errormsg)
        {
            // Skapa sql-anslutning
            SqlConnection dbConnection = new SqlConnection();

            // Koppla mot SQL-server
            dbConnection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Laboration3;Integrated Security=True";

            // SQL-sträng för att lägga till i databasen
            String sqlstring = "UPDATE Movie SET Name = @name, Genre = @genre, Playtime = @playtime, Year = @year, IMDBScore = @imdbscore, Director = @director WHERE Id = @id";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("name", SqlDbType.NVarChar, 50).Value = md.Name;
            dbCommand.Parameters.Add("genre", SqlDbType.NVarChar, 20).Value = md.Genre;
            dbCommand.Parameters.Add("playtime", SqlDbType.Int).Value = md.Playtime;
            dbCommand.Parameters.Add("year", SqlDbType.Int).Value = md.Year;
            dbCommand.Parameters.Add("imdbscore", SqlDbType.Float).Value = md.IMDBScore;
            dbCommand.Parameters.Add("director", SqlDbType.NVarChar, 50).Value = md.Director;
            dbCommand.Parameters.Add("id", SqlDbType.Int).Value = md.Id;

            try
            {
                dbConnection.Open();
                int i = 0;
                i = dbCommand.ExecuteNonQuery();
                if (i == 1) { errormsg = ""; }
                else { errormsg = "Filmen ändrades inte"; }
                return (i);
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return 0;
            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}
