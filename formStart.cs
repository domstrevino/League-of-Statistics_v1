using System.Text;
using HtmlAgilityPack;
using System.Runtime.InteropServices;

namespace WindowsApplication
{
    public partial class formStart : Form
    {
        //Imports dll to create the round rectangle shape of the application.
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //Creates a round rectangle for the formStart windows form application.
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public formStart()
        {
            InitializeComponent();

            //Sets the windows form application to a round rectangle.
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }



        /*-------------------------------------->WEB SCRAPING METHODS<--------------------------------------*/

        //This method accesses the user's Region Rank in North America from OP.GG.
        private static string GetRank(string userRank)
        {
            //Initializes and declares the string 'url' variable using the OP.GG HTTP address and interpolating the 'userName' string into the url.
            string url = $"https://na.op.gg/summoners/na/{userName}";

            //Creates a new HtmlWeb class object, named 'website', to get and HTML document from an HTTP address.
            HtmlWeb website = new();

            //Creates an HtmlDocument, named 'document', that loads the HtmlWeb class 'website' from an internet source using the string url variable.
            HtmlAgilityPack.HtmlDocument document = website.Load(url);

            //Declares an HtmlNode List, named 'datalist'.
            List<HtmlNode> datalist;

            //Validates whether or not the requested node in the HtmlDocument 'document', is NOT null.
            if (document.DocumentNode.SelectNodes("//span[@class='ranking']").ToList() != null)
            {
                //Initializes the HtmlNode, 'datalist', by selecting the list of nodes that match the XPath expression.
                datalist = document.DocumentNode.SelectNodes("//span[@class='ranking']").ToList();

                //For each HtmlNode,'item', in the HtmlNode List, 'datalist'.
                foreach (HtmlNode item in datalist)
                {
                    //Initializes the method parameter 'userRank' to the contents between the start and end tags of the HtmlNode 'item'.
                    userRank = item.InnerHtml;
                }
            }
            else
            {
                userRank = "Unavailable.";
            }

            //Return the trimmed(removed leading and trailing white-space characters) method parameter 'userRank'.
            return userRank.Trim();
        }

        //This method accesses the user's Division Rank in North America from OP.GG.
        private static string GetDivision(string userDivision)
        {
            string url = $"https://na.op.gg/summoners/na/{userName}";
            HtmlWeb website = new();
            HtmlAgilityPack.HtmlDocument document = website.Load(url);
            List<HtmlNode> datalist = document.DocumentNode.SelectNodes("(//div[@class='tier-rank' or @class = 'unranked'])[1]").ToList();
            foreach (HtmlNode item in datalist)
            {
                userDivision = item.InnerHtml;
            }

            //Creates a new StringBuilder class object, named 'stringBuilder', that represents a mutable string of characters.
            StringBuilder stringBuilder = new();

            //For each iteration: integer 'i' is equal to 0, integer 'i' is less than the length of the string 'userDivision', increment the iteration process using the integer 'i'.
            for (int i = 0; i < userDivision.Length; i++)
            {
                //Conditionally checks that each string character in the string 'userDivision' is >= 0 and <= 9 OR is between A and z, OR is special characters, OR is white-space.
                if ((userDivision[i] >= '0' && userDivision[i] <= '9') || (userDivision[i] >= 'A' && userDivision[i] <= 'z') || (userDivision[i] == '.' && userDivision[i] == '_') || (userDivision[i] == ' '))
                {
                    //Append each string character from the string 'userDivision' to the stringBuidler object.
                    stringBuilder.Append(userDivision[i]);
                }
            }

            //Initializes the method parameter 'userDivision' to the 'stringBuilder' variable after converting the value to a string and uppercase.
            userDivision = stringBuilder.ToString().ToUpper();
            return userDivision;
        }

        //This method accesses the user's Flex Rank in North America from OP.GG.
        private static string GetFlex(string userFlex)
        {
            string url = $"https://na.op.gg/summoners/na/{userName}";
            HtmlWeb website = new();
            HtmlAgilityPack.HtmlDocument doc = website.Load(url);
            List<HtmlNode> datalist = doc.DocumentNode.SelectNodes("(//div[@class='tier-rank' or @class = 'unranked'])[2]").ToList();
            foreach (HtmlNode item in datalist)
            {
                userFlex = item.InnerHtml;
            }

            StringBuilder stringBuilder = new();
            for (int i = 0; i < userFlex.Length; i++)
            {
                if ((userFlex[i] >= '0' && userFlex[i] <= '9') || (userFlex[i] >= 'A' && userFlex[i] <= 'z') || (userFlex[i] == '.' && userFlex[i] == '_') || (userFlex[i] == ' '))
                {
                    stringBuilder.Append(userFlex[i]);
                }
            }

            userFlex = stringBuilder.ToString().ToUpper();
            return userFlex;
        }

        /*-------------------------------------->END WEB SCRAPING METHODS<--------------------------------------*/



        /*-------------------------------------->BUTTON CLICK EVENTS<--------------------------------------*/

        //Exit button click event.
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            //Exit the application.
            Application.Exit();
        }

        //Start button click event.
        private void BtnStart_Click(object sender, EventArgs e)
        {
            //Sets username from SummonerName textbox.
            userName = SummonerName.Text;

            //Declares division string by accessing the GetDivision method.
            division = GetDivision(userName);

            //Declares flex string by accessing the GetFlex method.
            flex = GetFlex(userName);

            //Checking whether either the flex or division strings come back as unranked.
            if (division != "UNRANKED" || flex != "UNRANKED")
            {
                //If both division string and flex string do NOT come back as UNRANKED, Declares rank string by accessing the GetRank method.
                rank = GetRank(userName);
            }
            else
            {
                //If either division string or flex string DOES come back as UNRANKED, Declares rank string as UNRANKED.
                rank = "UNRANKED";
            }

            //Opens the formHome windows form.
            formHome f2 = new();
            this.Hide();
            f2.Show();
        }

        /*-------------------------------------->END BUTTON CLICK EVENTS<--------------------------------------*/



        /*-------------------------------------->OTHER EVENTS<--------------------------------------*/

        //Summoner name Text Changed event.
        private void SummonerName_TextChanged(object sender, EventArgs e)
        {
            //Changes color of text to standard black once the user begins typing in the SummonerName textbox.
            SummonerName.ForeColor = Color.FromArgb(0, 0, 0);
        }

        /*-------------------------------------->END OTHER EVENTS<--------------------------------------*/
    }
}
