using System.Data.SqlClient;

namespace WindowsApplication
{
    public partial class frmChampions : Form
    {
        //Initializes and declares a new instance of the SqlConnection class, named 'connection', with the connection string for the SQL Database.
        private readonly SqlConnection connection = new(@"Data Source=DESKTOP-PO0GU27\SQLEXPRESS;Initial Catalog=WindowsApplication;Integrated Security=True");

        //Declares a new instance of the SqlCommand class, named 'command'.
        private SqlCommand? command;

        //Declares a new instance of the SqlDataReader class, named 'dataReader'.
        private SqlDataReader? dataReader;

        public frmChampions()
        {
            InitializeComponent();
        }


        //Load Champion List event.
        private void FrmChampions_Load(object sender, EventArgs e)
        {
            //Initializes the SqlCommand 'command' instance.
            command = new SqlCommand();

            //Opens the database connection using the SqlConnection string 'connection'.
            connection.Open();

            //Sets the SqlConnection string 'connection' using the 'command' instance. 
            command.Connection = connection;

            //Sets the SqlCommand 'command' to a string that will be executed within the database.
            //Selects ALL from the table "Champs".
            command.CommandText = "SELECT * FROM Champs";

            //Initializes the SqlDataReader instance, 'dataReader', using the SqlCommand instance 'command'
            dataReader = command.ExecuteReader();

            //While the instance 'dataReader' reads the database records.
            while (dataReader.Read())
            {
                //Adds each item to the ChampionListBox that are listed as a "Champ".
                ChampionListBox.Items.Add(dataReader["Champ"]);
            }

            //Closes the database connection using the SqlConnection string 'connection'.
            connection.Close();
        }

        //ChampionListBox Selected Index Changed event.
        private void ChampionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*-------------------------------------->CHAMPION NAME<--------------------------------------*/

            //Initializes the ChampTextBox text using the selected list item from the ChampionListBox.
            ChampTextBox.Text = ChampionListBox.SelectedItem.ToString();

            command = new();
            connection.Open();
            command.Connection = connection;

            //Selects the ChampName from the table "Champs" where the Champ is equal to the currently selected item from the ChampionListBox.
            command.CommandText = "SELECT ChampName FROM Champs WHERE Champ = '" + ChampionListBox.SelectedItem + "'";
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                //Sets the ChampName text. 
                ChampName.Text = (string)dataReader["ChampName"];
            }
            dataReader.Close();

            /*-------------------------------------->END CHAMPION NAME<--------------------------------------*/
            //
            //
            //
            /*-------------------------------------->CHAMPION Q ABILITY<--------------------------------------*/

            command = new();
            command.Connection = connection;

            //Selects the Q from the table "ChampAbilities" where the Champ is equal to the currently selected item from the ChampionListBox.
            command.CommandText = "SELECT Q FROM ChampAbilities WHERE Champ = '" + ChampionListBox.SelectedItem + "'";
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                QTextBox.Text = (string)dataReader["Q"];
            }
            dataReader.Close();

            /*-------------------------------------->END CHAMPION Q<--------------------------------------*/
            //
            //
            //
            /*-------------------------------------->CHAMPION W ABILITY<--------------------------------------*/

            command = new();
            command.Connection = connection;

            //Selects the W from the table "ChampAbilities" where the Champ is equal to the currently selected item from the ChampionListBox.
            command.CommandText = "SELECT W FROM ChampAbilities WHERE Champ = '" + ChampionListBox.SelectedItem + "'";
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                //Sets the WTextBox text.
                WTextBox.Text = (string)dataReader["W"];
            }
            dataReader.Close();

            /*-------------------------------------->END CHAMPION W<--------------------------------------*/
            //
            //
            //
            /*-------------------------------------->CHAMPION E ABILITY<--------------------------------------*/

            command = new();
            command.Connection = connection;

            //Selects the E from the table "ChampAbilities" where the Champ is equal to the currently selected item from the ChampionListBox.
            command.CommandText = "SELECT E FROM ChampAbilities WHERE Champ = '" + ChampionListBox.SelectedItem + "'";
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                //Sets the ETextBox text.
                ETextBox.Text = (string)dataReader["E"];
            }
            dataReader.Close();

            /*-------------------------------------->END CHAMPION E<--------------------------------------*/
            //
            //
            //
            /*-------------------------------------->CHAMPION R ABILITY<--------------------------------------*/

            command = new();
            command.Connection = connection;

            //Selects the R from the table "ChampAbilities" where the Champ is equal to the currently selected item from the ChampionListBox.
            command.CommandText = "SELECT R FROM ChampAbilities WHERE Champ = '" + ChampionListBox.SelectedItem + "'";
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                //Sets the RTextBox text.
                RTextBox.Text = (string)dataReader["R"];
            }
            dataReader.Close();

            /*-------------------------------------->END CHAMPION R<--------------------------------------*/

            //Closes the database connection using the 'connection' instance.
            connection.Close();

            //Initializes the ChampionPicture picturebox.
            ChampionPicture.ImageLocation = "https://static.wikia.nocookie.net/leagueoflegends/images/7/7e/Ashe_OriginalSquare.png/revision/latest/scale-to-width-down/96?cb=20150402215403";
        }
    }
}
