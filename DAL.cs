using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
namespace MovieApp
{
   

    public class DAL
    {
        private string connectionString = "server=localhost;database=MovieDB;user=root;password=Kwanele@050509";

        public List<Movie> GetAllMovies()
        {
           // The GetAllMovies method retrieves all the movies stored in the tblMovie table in the
           // MySQL database and returns them as a list of Movie objects
            List<Movie> movies = new List<Movie>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tblMovie";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        movies.Add(new Movie
                        {
                            MovieID = reader.GetInt32("movieID"),
                            MovieTitle = reader.GetString("movieTitle"),
                            Genre = reader.GetString("genre"),
                            SellingPrice = reader.GetDecimal("sellingPrice")
                        });
                    }
                }
            }
            return movies;
        }

        public void AddMovie(Movie movie)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO tblMovie (movieTitle, genre, sellingPrice) VALUES (@title, @genre, @price)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", movie.MovieTitle);
                cmd.Parameters.AddWithValue("@genre", movie.Genre);
                cmd.Parameters.AddWithValue("@price", movie.SellingPrice);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteMovie(int movieID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM tblMovie WHERE movieID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", movieID);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateMovie(Movie movie)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE tblMovie SET movieTitle = @title, genre = @genre, sellingPrice = @price WHERE movieTitle = @title";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", movie.MovieTitle);
                cmd.Parameters.AddWithValue("@genre", movie.Genre);
                cmd.Parameters.AddWithValue("@price", movie.SellingPrice);
                cmd.Parameters.AddWithValue("@id", movie.MovieID);

                cmd.ExecuteNonQuery();
            }
        }

        public Movie SearchMovieByTitle(string title)
        {
            Movie movie = null;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tblMovie WHERE movieTitle = @title";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", title);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        movie = new Movie
                        {
                            MovieID = reader.GetInt32("movieID"),
                            MovieTitle = reader.GetString("movieTitle"),
                            Genre = reader.GetString("genre"),
                            SellingPrice = reader.GetDecimal("sellingPrice")
                        };
                    }
                }
            }
            return movie;
        }
    }

}
