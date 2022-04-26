using HtmlAgilityPack;
using System.Text;

namespace WindowsApplication
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            //Sets MainChampion, FirstWR, and MainKDA into textboxes.
            MainChampion.Text = "Main Champion: " + GetChampions(formStart.userName);
            FirstWR.Text = GetWR(formStart.userName);
            MainKDA.Text = GetKDA(formStart.userName);

            //Sets SecondChampion, SecondWR, and SecondKDA into textboxes.
            SecondChampion.Text = "Secondary Champion: " + GetSecondaryChamp(formStart.userName);
            SecondWR.Text = GetSecondaryWR(formStart.userName);
            SecondKDA.Text = GetSecondaryKDA(formStart.userName);

            //Sets ThirdChampion, ThirdWR, and ThirdKDA into textboxes.
            ThirdChampion.Text = "Tertiary Champion: " + GetTertiaryChamp(formStart.userName);
            ThirdWR.Text = GetTertiaryWR(formStart.userName);
            ThirdKDA.Text = GetTertiaryKDA(formStart.userName);
        }

        /*-------------------------------------->WEB SCRAPING METHODS<--------------------------------------*/

        //This method accesses the user's most played champion in North America from U.GG.
        private static string GetChampions(string firstChampion)
        {
            string url = $"https://u.gg/lol/profile/na1/{formStart.userName}/champion-stats";
            HtmlWeb website = new();
            HtmlAgilityPack.HtmlDocument doc = website.Load(url);
            List<HtmlNode> datalist = doc.DocumentNode.SelectNodes("(//span[@class='champion-name'])[1]").ToList();
            foreach (HtmlNode item in datalist)
            {
                firstChampion = item.InnerHtml;
            }

            StringBuilder stringBuilder = new();
            for (int i = 0; i < firstChampion.Length; i++)
            {
                if ((firstChampion[i] >= '0' && firstChampion[i] <= '9')
                    || (firstChampion[i] >= 'A' && firstChampion[i] <= 'z'
                        || (firstChampion[i] == '.' && firstChampion[i] == '_'))
                            || (firstChampion[i] == ' '))
                {
                    stringBuilder.Append(firstChampion[i]);
                }
            }

            firstChampion = stringBuilder.ToString();
            return firstChampion;
        }

        //This method accesses the user's most played champion's winrate in North America from U.GG.
        private static string GetWR(string firstWR)
        {
            string url = $"https://u.gg/lol/profile/na1/{formStart.userName}/champion-stats";
            HtmlWeb website = new();
            HtmlAgilityPack.HtmlDocument doc = website.Load(url);
            List<HtmlNode> datalist = doc.DocumentNode.SelectNodes("(//span[@class='match-record'])[1]").ToList();
            foreach (HtmlNode item in datalist)
            {
                firstWR = item.InnerHtml;
            }

            StringBuilder stringBuilder = new();
            for (int i = 0; i < firstWR.Length; i++)
            {
                if ((firstWR[i] >= '0' && firstWR[i] <= '9')
                    || (firstWR[i] >= 'A' && firstWR[i] <= 'z'
                        || (firstWR[i] == '.' && firstWR[i] == '_'))
                            || (firstWR[i] == ' '))
                {
                    stringBuilder.Append(firstWR[i]);
                }
            }

            firstWR = stringBuilder.ToString();
            return firstWR;
        }

        //This method accesses the user's most played champion's KDA in North America from U.GG.
        private static string GetKDA(string firstKDA)
        {
            string url = $"https://na.op.gg/summoners/na/{formStart.userName}";
            HtmlWeb website = new();
            HtmlAgilityPack.HtmlDocument doc = website.Load(url);
            List<HtmlNode> datalist = doc.DocumentNode.SelectNodes("(//div[@class = 'kda'])[1]//div[1]").ToList();
            foreach (HtmlNode item in datalist)
            {
                firstKDA = item.InnerHtml;
            }

            return firstKDA;
        }



        //This method accesses the user's second most played champion in North America from U.GG.
        private static string GetSecondaryChamp(string secondChampion)
        {
            string url = $"https://u.gg/lol/profile/na1/{formStart.userName}/champion-stats";
            HtmlWeb website = new();
            HtmlAgilityPack.HtmlDocument doc = website.Load(url);
            List<HtmlNode> datalist = doc.DocumentNode.SelectNodes("(//span[@class='champion-name'])[2]").ToList();
            foreach (HtmlNode item in datalist)
            {
                secondChampion = item.InnerHtml;
            }

            StringBuilder stringBuilder = new();
            for (int i = 0; i < secondChampion.Length; i++)
            {
                if ((secondChampion[i] >= '0' && secondChampion[i] <= '9')
                    || (secondChampion[i] >= 'A' && secondChampion[i] <= 'z'
                        || (secondChampion[i] == '.' && secondChampion[i] == '_'))
                            || (secondChampion[i] == ' '))
                {
                    stringBuilder.Append(secondChampion[i]);
                }
            }

            secondChampion = stringBuilder.ToString();
            return secondChampion;
        }

        //This method accesses the user's second most played champion's winrate in North America from U.GG.
        private static string GetSecondaryWR(string secondWR)
        {
            string url = $"https://u.gg/lol/profile/na1/{formStart.userName}/champion-stats";
            HtmlWeb website = new();
            HtmlAgilityPack.HtmlDocument doc = website.Load(url);
            List<HtmlNode> datalist = doc.DocumentNode.SelectNodes("(//span[@class='match-record'])[2]").ToList();
            foreach (HtmlNode item in datalist)
            {
                secondWR = item.InnerHtml;
            }

            StringBuilder stringBuilder = new();
            for (int i = 0; i < secondWR.Length; i++)
            {
                if ((secondWR[i] >= '0' && secondWR[i] <= '9')
                    || (secondWR[i] >= 'A' && secondWR[i] <= 'z'
                        || (secondWR[i] == '.' && secondWR[i] == '_'))
                            || (secondWR[i] == ' '))
                {
                    stringBuilder.Append(secondWR[i]);
                }
            }

            secondWR = stringBuilder.ToString();
            return secondWR;
        }

        //This method accesses the user's second most played champion's KDA in North America from U.GG.
        private static string GetSecondaryKDA(string secondKDA)
        {
            string url = $"https://na.op.gg/summoners/na/{formStart.userName}";
            HtmlWeb website = new();
            HtmlAgilityPack.HtmlDocument doc = website.Load(url);
            List<HtmlNode> datalist = doc.DocumentNode.SelectNodes("(//div[@class = 'kda'])[2]//div[1]").ToList();
            foreach (HtmlNode item in datalist)
            {
                secondKDA = item.InnerHtml;
            }

            return secondKDA;
        }



        //This method accesses the user's third most played champion in North America from U.GG.
        private static string GetTertiaryChamp(string thirdChampion)
        {
            string url = $"https://u.gg/lol/profile/na1/{formStart.userName}/champion-stats";
            HtmlWeb website = new();
            HtmlAgilityPack.HtmlDocument doc = website.Load(url);
            List<HtmlNode> datalist = doc.DocumentNode.SelectNodes("(//span[@class='champion-name'])[3]").ToList();
            foreach (HtmlNode item in datalist)
            {
                thirdChampion = item.InnerHtml;
            }

            StringBuilder stringBuilder = new();
            for (int i = 0; i < thirdChampion.Length; i++)
            {
                if ((thirdChampion[i] >= '0' && thirdChampion[i] <= '9')
                    || (thirdChampion[i] >= 'A' && thirdChampion[i] <= 'z'
                        || (thirdChampion[i] == '.' && thirdChampion[i] == '_'))
                            || (thirdChampion[i] == ' '))
                {
                    stringBuilder.Append(thirdChampion[i]);
                }
            }

            thirdChampion = stringBuilder.ToString();
            return thirdChampion;
        }

        //This method accesses the user's third most played champion's winrate in North America from U.GG.
        private static string GetTertiaryWR(string thirdWR)
        {
            string url = $"https://u.gg/lol/profile/na1/{formStart.userName}/champion-stats";
            HtmlWeb website = new();
            HtmlAgilityPack.HtmlDocument doc = website.Load(url);
            List<HtmlNode> datalist = doc.DocumentNode.SelectNodes("(//span[@class='match-record'])[3]").ToList();
            foreach (HtmlNode item in datalist)
            {
                thirdWR = item.InnerHtml;
            }

            StringBuilder stringBuilder = new();
            for (int i = 0; i < thirdWR.Length; i++)
            {
                if ((thirdWR[i] >= '0' && thirdWR[i] <= '9')
                    || (thirdWR[i] >= 'A' && thirdWR[i] <= 'z'
                        || (thirdWR[i] == '.' && thirdWR[i] == '_'))
                            || (thirdWR[i] == ' '))
                {
                    stringBuilder.Append(thirdWR[i]);
                }
            }

            thirdWR = stringBuilder.ToString();
            return thirdWR;
        }

        //This method accesses the user's third most played champion's KDA in North America from U.GG.
        private static string GetTertiaryKDA(string thirdKDA)
        {
            string url = $"https://na.op.gg/summoners/na/{formStart.userName}";
            HtmlWeb website = new();
            HtmlAgilityPack.HtmlDocument doc = website.Load(url);
            List<HtmlNode> datalist = doc.DocumentNode.SelectNodes("(//div[@class = 'kda'])[3]//div[1]").ToList();

            foreach (HtmlNode item in datalist)
            {
                thirdKDA = item.InnerHtml;
            }
            return thirdKDA;
        }

        /*-------------------------------------->END WEB SCRAPING METHODS<--------------------------------------*/
    }
}
