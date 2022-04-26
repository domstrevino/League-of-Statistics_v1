using HtmlAgilityPack;
using System.Text;

namespace WindowsApplication
{
    public partial class frmRank : Form
    {
        public frmRank()
        {
            InitializeComponent();
        }

        //Load Rank event.
        private void FrmRank_Load(object sender, EventArgs e)
        {
            //Sets Summoner Level, Total Games, Winrate, and Name into textboxes.
            summonerLevel.Text = "Level: " + GetLevel(formStart.userName);
            totalGames.Text = "Total Games: " + GetGames(formStart.userName);
            winRate.Text = GetPercentWR(formStart.userName);
            NameTxtBox.Text = formStart.userName;

            //Sets Region Rank, Division Rank, and Flex Rank into textboxes. Concatenates the GetSoloLP method to the divisionRank textbox.
            regionRank.Text = $"Region Rank: #{formStart.rank}";
            divisionRank.Text = $"Ranked Solo: {formStart.division} / " + GetSoloLP(formStart.userName);
            flexRank.Text = $"Ranked Flex: {formStart.flex}";
        }

        /*-------------------------------------->WEB SCRAPING METHODS<--------------------------------------*/

        //This method accesses the user's account level in North America from U.GG.
        private static string GetLevel(string level)
        {
            string url = $"https://u.gg/lol/profile/na1/{formStart.userName}/overview";
            var website = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = website.Load(url);
            var datalist = doc.DocumentNode.SelectNodes("(//div[@class='level-header'])").ToList();

            foreach (HtmlNode item in datalist)
            {
                level = item.InnerHtml;
            }

            StringBuilder stringBuilder = new();
            for (int i = 0; i < level.Length; i++)
            {
                if ((level[i] >= '0' && level[i] <= '9')
                    || (level[i] >= 'A' && level[i] <= 'z'
                        || (level[i] == '.' && level[i] == '_'))
                            || (level[i] == ' '))
                {
                    stringBuilder.Append(level[i]);
                }
            }
            level = stringBuilder.ToString().ToUpper();
            return level;
        }

        //This method accesses the user's total games played in North America from U.GG.
        private static string GetGames(string games)
        {
            string url = $"https://u.gg/lol/profile/na1/{formStart.userName}/overview";
            var website = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = website.Load(url);
            var datalist = doc.DocumentNode.SelectNodes("(//span[@class='total-games'])[1]").ToList();

            foreach (var item in datalist)
            {
                games = item.InnerHtml;
            }

            StringBuilder stringBuilder = new();
            for (int i = 0; i < games.Length; i++)
            {
                if ((games[i] >= '0' && games[i] <= '9')
                    || (games[i] >= 'A' && games[i] <= 'z'
                        || (games[i] == '.' && games[i] == '_'))
                            || (games[i] == ' '))
                {
                    stringBuilder.Append(games[i]);
                }
            }
            games = stringBuilder.ToString();
            return games;
        }

        //This method accesses the user's percent winrate in North America from U.GG.
        private static string GetPercentWR(string wins)
        {
            string url = $"https://u.gg/lol/profile/na1/{formStart.userName}/overview";
            var website = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = website.Load(url);
            var datalist = doc.DocumentNode.SelectNodes("(//div[@class='rank-wins'])//strong").ToList();

            foreach (var item in datalist)
            {
                wins = item.InnerHtml;
            }
            return wins;
        }

        //This method accesses the user's Solo/Duo LP in North America from U.GG.
        private static string GetSoloLP(string points)
        {
            string url = $"https://u.gg/lol/profile/na1/{formStart.userName}/overview";
            var website = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = website.Load(url);
            var datalist = doc.DocumentNode.SelectNodes("(//div[@class='rank-text']//strong)[2]").ToList();

            foreach (var item in datalist)
            {
                points = item.InnerHtml;
            }
            return points;
        }

        /*-------------------------------------->END WEB SCRAPING METHODS<--------------------------------------*/
    }
}
