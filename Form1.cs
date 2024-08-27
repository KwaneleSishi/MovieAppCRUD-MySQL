namespace MovieApp
{
    public partial class Form1 : Form
    {
        private DAL dal;

        public Form1()
        {
            InitializeComponent();
            dgvMovies.CellClick += dgvMovies_CellClick;
            dal = new DAL();
            LoadMovies(); // Loading movies when the form is initialized
        }

        private void LoadMovies()
        {
            var movies = dal.GetAllMovies();
            dgvMovies.DataSource = movies;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie
            {
                MovieTitle = txtTitle.Text,
                Genre = txtGenre.Text,
                SellingPrice = Convert.ToDecimal(txtPrice.Text)
            };
            dal.AddMovie(movie);
            LoadMovies();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dgvMovies.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvMovies.SelectedRows[0];
                int movieID = Convert.ToInt32(row.Cells["MovieID"].Value);

                // Validate the SellingPrice input
                if (decimal.TryParse(txtPrice.Text, out decimal sellingPrice))
                {
                    Movie movie = new Movie
                    {
                        MovieID = movieID,
                        MovieTitle = txtTitle.Text,
                        Genre = txtGenre.Text,
                        SellingPrice = sellingPrice
                    };
                    dal.UpdateMovie(movie);
                    LoadMovies(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Please enter a valid price.");
                }
            }
            else
            {
                MessageBox.Show("Please select a movie to update.");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dgvMovies.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvMovies.SelectedRows[0];
                int movieID = Convert.ToInt32(row.Cells["MovieID"].Value);

                dal.DeleteMovie(movieID);
                LoadMovies(); // Refresh DataGridView
            }
            else
            {
                MessageBox.Show("Please select a movie to delete.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            var movie = dal.SearchMovieByTitle(title);
            if (movie != null)
            {
                txtTitle.Text = movie.MovieTitle;
                txtGenre.Text = movie.Genre;
                txtPrice.Text = movie.SellingPrice.ToString();
            }
            else
            {
                MessageBox.Show("Movie not found.");
            }
        }

        private void dgvMovies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvMovies.SelectedRows[0];
                txtTitle.Text = row.Cells["MovieTitle"].Value.ToString();
                txtGenre.Text = row.Cells["Genre"].Value.ToString();
                txtPrice.Text = row.Cells["SellingPrice"].Value.ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtGenre.Text = "";
            txtPrice.Text = "";

        }
        // Assuming your DataGridView is named dgvMovies
        

        private void dgvMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the row index is valid (e.g., not a header row)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvMovies.Rows[e.RowIndex];

                // Populate the text fields with the selected row's data
                txtTitle.Text = row.Cells["MovieTitle"].Value.ToString();
                txtGenre.Text = row.Cells["Genre"].Value.ToString();
                txtPrice.Text = row.Cells["SellingPrice"].Value.ToString();
            }
        }
    }
}
