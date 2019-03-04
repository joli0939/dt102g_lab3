using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Laboration3.Models
{
    public class ActorMethods
    {
        // Konstruktor
        public ActorMethods() { }

        public List<ActorDetail> GetActorList(out string errormsg)
        {
            // Skapa sql-anslutning
            SqlConnection dbConnection = new SqlConnection();

            // Koppla mot SQL-server
            dbConnection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Laboration3;Integrated Security=True";

            // SQL-sträng för att lägga till i databasen
            String sqlstring = "SELECT * FROM Actor";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            // Skapa en adapter
            SqlDataAdapter myAdapter = new SqlDataAdapter(dbCommand);
            DataSet myDS = new DataSet();

            List<ActorDetail> ActorList = new List<ActorDetail>();

            try
            {
                dbConnection.Open();

                // Fyller dataset
                myAdapter.Fill(myDS, "myActor");

                int count = 0;
                int i = 0;
                count = myDS.Tables["myActor"].Rows.Count;

                if (count > 0)
                {
                    while (i < count)
                    {
                        ActorDetail ad = new ActorDetail();
                        ad.Forename = myDS.Tables["myActor"].Rows[i]["Forename"].ToString();
                        ad.Surname = myDS.Tables["myActor"].Rows[i]["Surname"].ToString();
                        ad.DateOfBirth = Convert.ToDateTime(myDS.Tables["myActor"].Rows[i]["DateOfBirth"]);
                        ad.Id = Convert.ToInt32(myDS.Tables["myActor"].Rows[i]["Id"]);

                        i++;
                        ActorList.Add(ad);
                    }

                    errormsg = "";
                    return ActorList;
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

        public int InsertActor(ActorDetail ad, out string errormsg)
        {
            // Skapa sql-anslutning
            SqlConnection dbConnection = new SqlConnection();

            // Koppla mot SQL-server
            dbConnection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Laboration3;Integrated Security=True";

            // SQL-sträng för att lägga till i databasen
            String sqlstring = "INSERT INTO Actor (Forename, Surname, DateOfBirth) VALUES (@forename, @surname, @dateofbirth)";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("forename", SqlDbType.NVarChar, 20).Value = ad.Forename;
            dbCommand.Parameters.Add("surname", SqlDbType.NVarChar, 20).Value = ad.Surname;
            dbCommand.Parameters.Add("dateofbirth", SqlDbType.DateTime).Value = ad.DateOfBirth;

            try
            {
                dbConnection.Open();
                int i = 0;
                i = dbCommand.ExecuteNonQuery();
                if (i == 1) { errormsg = ""; }
                else { errormsg = "Det lades inte till någon skådespelare i databasen"; }
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

        public List<ActorMovie> GetActorMovieList(out string errormsg)
        {
            // Skapa sql-anslutning
            SqlConnection dbConnection = new SqlConnection();

            // Koppla mot SQL-server
            dbConnection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Laboration3;Integrated Security=True";

            // SQL-sträng för att lägga till i databasen
            String sqlstring = "SELECT Actor.Forename, Actor.Surname, Movie.Name, Actor.Id AS 'ActorId', Movie.Id AS 'MovieId' FROM((ConnectActorMovie INNER JOIN Actor ON ConnectActorMovie.ActorId = Actor.Id) INNER JOIN Movie ON ConnectActorMovie.MovieId = Movie.Id)";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            // Skapa en adapter
            SqlDataAdapter myAdapter = new SqlDataAdapter(dbCommand);
            DataSet myDS = new DataSet();

            List<ActorMovie> ActorMovieList = new List<ActorMovie>();

            try
            {
                dbConnection.Open();

                // Fyller dataset
                myAdapter.Fill(myDS, "myActorMovie");

                int count = 0;
                int i = 0;
                count = myDS.Tables["myActorMovie"].Rows.Count;

                if (count > 0)
                {
                    while (i < count)
                    {
                        ActorMovie aMovie = new ActorMovie();
                        aMovie.Forename = myDS.Tables["myActorMovie"].Rows[i]["Forename"].ToString();
                        aMovie.Surname = myDS.Tables["myActorMovie"].Rows[i]["Surname"].ToString();
                        aMovie.Movie = myDS.Tables["myActorMovie"].Rows[i]["Name"].ToString();
                        aMovie.ActorId = Convert.ToInt32(myDS.Tables["myActorMovie"].Rows[i]["ActorId"]);
                        aMovie.MovieId = Convert.ToInt32(myDS.Tables["myActorMovie"].Rows[i]["MovieId"]);

                        i++;
                        ActorMovieList.Add(aMovie);
                    }

                    errormsg = "";
                    return ActorMovieList;
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

        public List<ActorMovie> GetActorMovieList(out string errormsg, int filterID)
        {
            // Skapa sql-anslutning
            SqlConnection dbConnection = new SqlConnection();

            // Koppla mot SQL-server
            dbConnection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Laboration3;Integrated Security=True";

            // SQL-sträng för att lägga till i databasen
            String sqlstring = "SELECT Actor.Forename, Actor.Surname, Movie.Name, Actor.Id AS 'ActorId', Movie.Id AS 'MovieId' FROM((ConnectActorMovie INNER JOIN Actor ON ConnectActorMovie.ActorId = Actor.Id) INNER JOIN Movie ON ConnectActorMovie.MovieId = Movie.Id) WHERE Actor.Id = @filterID";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("filterID", SqlDbType.Int).Value = filterID;

            // Skapa en adapter
            SqlDataAdapter myAdapter = new SqlDataAdapter(dbCommand);
            DataSet myDS = new DataSet();

            List<ActorMovie> ActorMovieList = new List<ActorMovie>();

            try
            {
                dbConnection.Open();

                // Fyller dataset
                myAdapter.Fill(myDS, "myActorMovie");

                int count = 0;
                int i = 0;
                count = myDS.Tables["myActorMovie"].Rows.Count;

                if (count > 0)
                {
                    while (i < count)
                    {
                        ActorMovie aMovie = new ActorMovie();
                        aMovie.Forename = myDS.Tables["myActorMovie"].Rows[i]["Forename"].ToString();
                        aMovie.Surname = myDS.Tables["myActorMovie"].Rows[i]["Surname"].ToString();
                        aMovie.Movie = myDS.Tables["myActorMovie"].Rows[i]["Name"].ToString();
                        aMovie.ActorId = Convert.ToInt32(myDS.Tables["myActorMovie"].Rows[i]["ActorId"]);
                        aMovie.MovieId = Convert.ToInt32(myDS.Tables["myActorMovie"].Rows[i]["MovieId"]);

                        i++;
                        ActorMovieList.Add(aMovie);
                    }

                    errormsg = "";
                    return ActorMovieList;
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

        public ActorDetail GetActor(out string errormsg, int actorId)
        {
            // Skapa sql-anslutning
            SqlConnection dbConnection = new SqlConnection();

            // Koppla mot SQL-server
            dbConnection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Laboration3;Integrated Security=True";

            // SQL-sträng för att lägga till i databasen
            String sqlstring = "SELECT * FROM Actor WHERE Id = @actorId";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("userId", SqlDbType.NVarChar, 450).Value = userId;

            // Skapa en adapter
            SqlDataAdapter myAdapter = new SqlDataAdapter(dbCommand);
            DataSet myDS = new DataSet();

            ActorDetail Actor = new ActorDetail();

            try
            {
                dbConnection.Open();

                // Fyller dataset
                myAdapter.Fill(myDS, "myActor");

                int count = 0;
                int i = 0;
                count = myDS.Tables["myActor"].Rows.Count;

                if (count > 0)
                {
                    while (i < count)
                    {
                        ActorDetail ad = new ActorDetail();
                        ad.Forename = myDS.Tables["myActor"].Rows[i]["Forename"].ToString();
                        ad.Surname = myDS.Tables["myActor"].Rows[i]["Surname"].ToString();
                        ad.DateOfBirth = Convert.ToDateTime(myDS.Tables["myActor"].Rows[i]["DateOfBirth"]);
                        ad.Id = Convert.ToInt32(myDS.Tables["myActor"].Rows[i]["Id"]);

                        i++;
                        Actor = ad;
                    }

                    errormsg = "";
                    return Actor;
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

        public int UpdateActor(ActorDetail ad, out string errormsg)
        {
            // Skapa sql-anslutning
            SqlConnection dbConnection = new SqlConnection();

            // Koppla mot SQL-server
            dbConnection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Laboration3;Integrated Security=True";

            // SQL-sträng för att lägga till i databasen
            String sqlstring = "UPDATE Actor SET Forename = @forename, Surname = @surname, DateOfBirth = @dateofbirth WHERE Id = @id";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("forename", SqlDbType.NVarChar, 20).Value = ad.Forename;
            dbCommand.Parameters.Add("surname", SqlDbType.NVarChar, 20).Value = ad.Surname;
            dbCommand.Parameters.Add("dateofbirth", SqlDbType.DateTime).Value = ad.DateOfBirth;
            dbCommand.Parameters.Add("id", SqlDbType.Int).Value = ad.Id;

            try
            {
                dbConnection.Open();
                int i = 0;
                i = dbCommand.ExecuteNonQuery();
                if (i == 1) { errormsg = ""; }
                else { errormsg = "Skådespelaren ändrades inte"; }
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

        public int DeleteActor(int deleteId, out string errormsg)
        {
            // Skapa sql-anslutning
            SqlConnection dbConnection = new SqlConnection();

            // Koppla mot SQL-server
            dbConnection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Laboration3;Integrated Security=True";

            // SQL-sträng för att lägga till i databasen
            String sqlstring = "DELETE FROM Actor WHERE Id = @deleteId";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("deleteId", SqlDbType.Int).Value = deleteId;

            try
            {
                dbConnection.Open();
                int i = 0;
                i = dbCommand.ExecuteNonQuery();
                if (i == 1) { errormsg = ""; }
                else { errormsg = "Ingen skådespelare togs bort"; }
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

        public int ConnectActorMovie(ConnectActorMovieDetail camd, out string errormsg)
        {
            // Skapa sql-anslutning
            SqlConnection dbConnection = new SqlConnection();

            // Koppla mot SQL-server
            dbConnection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Laboration3;Integrated Security=True";

            // SQL-sträng för att lägga till i databasen
            String sqlstring = "INSERT INTO ConnectActorMovie (ActorId, MovieId) VALUES (@actor, @movie)";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("actor", SqlDbType.Int).Value = camd.ActorId;
            dbCommand.Parameters.Add("movie", SqlDbType.Int).Value = camd.MovieId;

            try
            {
                dbConnection.Open();
                int i = 0;
                i = dbCommand.ExecuteNonQuery();
                if (i == 1) { errormsg = ""; }
                else { errormsg = "Ingen koppling gjordes"; }
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

        public int DeleteConnection(ConnectActorMovieDetail camd, out string errormsg)
        {
            // Skapa sql-anslutning
            SqlConnection dbConnection = new SqlConnection();

            // Koppla mot SQL-server
            dbConnection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Laboration3;Integrated Security=True";

            // SQL-sträng för att lägga till i databasen
            String sqlstring = "DELETE FROM ConnectActorMovie WHERE ActorId = @actorId AND MovieId = @movieId";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            dbCommand.Parameters.Add("actorId", SqlDbType.Int).Value = camd.ActorId;
            dbCommand.Parameters.Add("movieId", SqlDbType.Int).Value = camd.MovieId;

            try
            {
                dbConnection.Open();
                int i = 0;
                i = dbCommand.ExecuteNonQuery();
                if (i == 1) { errormsg = ""; }
                else { errormsg = "Ingen skådespelare togs bort"; }
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
