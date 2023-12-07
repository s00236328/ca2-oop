
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace ca2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Team t1 = new Team() { Name = "France" };
        Team t2 = new Team() { Name = "Italy" };
        Team t3 = new Team() { Name = "Spain" };

        // French players
        Player p1 = new Player() { Name = "Marie", ResultRecord = "WWDDL", Rating = 0 };
        Player p2 = new Player() { Name = "Claude", ResultRecord = "DDDLW", Rating = 0 };
        Player p3 = new Player() { Name = "Antoine", ResultRecord = "LWDLW", Rating = 0 };

        // Italian players
        Player p4 = new Player() { Name = "Marco", ResultRecord = "WWDLL", Rating = 0 };
        Player p5 = new Player() { Name = "Giovanni", ResultRecord = "LLLLD", Rating = 0 };
        Player p6 = new Player() { Name = "Valentina", ResultRecord = "DLWWW", Rating = 0 };

        // Spanish players
        Player p7 = new Player() { Name = "Maria", ResultRecord = "WWWWW", Rating = 0 };
        Player p8 = new Player() { Name = "Jose", ResultRecord = "LLLLL", Rating = 0 };
        Player p9 = new Player() { Name = "Pablo", ResultRecord = "DDDDD", Rating = 0 };

        public MainWindow()
        {
            InitializeComponent();
            GetData();
            Calculate();
        }

        public void GetData()
        {
            LBXTeams.Items.Add(t1.Name);
            LBXTeams.Items.Add(t2.Name);
            LBXTeams.Items.Add(t3.Name);

            t1.Players.Add(p1);
            t1.Players.Add(p2);
            t1.Players.Add(p3);

            t2.Players.Add(p4);
            t2.Players.Add(p5);
            t2.Players.Add(p6);

            t3.Players.Add(p7);
            t3.Players.Add(p8);
            t3.Players.Add(p9);
        }

        public void Calculate()
        {
            p1.Rating = 0;
            p2.Rating = 0;
            p3.Rating = 0;
            p4.Rating = 0;
            p5.Rating = 0;
            p6.Rating = 0;
            p7.Rating = 0;
            p8.Rating = 0;
            p9.Rating = 0;

            foreach (char W in p1.ResultRecord)
            {
                if (W == 'W')
                {
                    p1.Rating += 3;
                }
            }
            foreach (char W in p2.ResultRecord)
            {
                if (W == 'W')
                {
                    p2.Rating += 3;
                }
            }
            foreach (char W in p3.ResultRecord)
            {
                if (W == 'W')
                {
                    p3.Rating += 3;
                }
            }
            foreach (char W in p4.ResultRecord)
            {
                if (W == 'W')
                {
                    p4.Rating += 3;
                }
            }
            foreach (char W in p5.ResultRecord)
            {
                if (W == 'W')
                {
                    p5.Rating += 3;
                }
            }
            foreach (char W in p6.ResultRecord)
            {
                if (W == 'W')
                {
                    p6.Rating += 3;
                }
            }
            foreach (char W in p7.ResultRecord)
            {
                if (W == 'W')
                {
                    p7.Rating += 3;
                }
            }
            foreach (char W in p8.ResultRecord)
            {
                if (W == 'W')
                {
                    p8.Rating += 3;
                }
            }
            foreach (char W in p9.ResultRecord)
            {
                if (W == 'W')
                {
                    p9.Rating += 3;
                }
            }


            foreach (char D in p1.ResultRecord)
            {
                if (D == 'D')
                {
                    p1.Rating ++;
                }
            }
            foreach (char D in p2.ResultRecord)
            {
                if (D == 'D')
                {
                    p2.Rating ++;
                }
            }
            foreach (char D in p3.ResultRecord)
            {
                if (D == 'D')
                {
                    p3.Rating++;
                }
            }
            foreach (char D in p4.ResultRecord)
            {
                if (D == 'D')
                {
                    p4.Rating++;
                }
            }
            foreach (char D in p5.ResultRecord)
            {
                if (D == 'D')
                {
                    p5.Rating++;
                }
            }
            foreach (char D in p6.ResultRecord)
            {
                if (D == 'D')
                {
                    p6.Rating++;
                }
            }
            foreach (char D in p7.ResultRecord)
            {
                if (D == 'D')
                {
                    p7.Rating++;
                }
            }
            foreach (char D in p8.ResultRecord)
            {
                if (D == 'D')
                {
                    p8.Rating++;
                }
            }
            foreach (char D in p9.ResultRecord)
            {
                if (D == 'D')
                {
                    p9.Rating++;
                }
            }
        }

        private void LBXTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Calculate();
            // Get the selected team
            string selectedTeam = LBXTeams.SelectedItem as string;

            // Display players of the selected team
            if (selectedTeam == t1.Name)
            {
                List<Player> players = t1.Players;
                LBXPlayers.Items.Clear(); // Clear existing items
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord + " - " + player.Rating);
                }
            }
            else if (selectedTeam == t2.Name)
            {
                List<Player> players = t2.Players;
                LBXPlayers.Items.Clear(); // Clear existing items
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord + " - " + player.Rating);
                }
            }
            else if (selectedTeam == t3.Name)
            {
                List<Player> players = t3.Players;
                LBXPlayers.Items.Clear(); // Clear existing items
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord + " - " + player.Rating);
                }
            }
            else
            {
                // Clear LBXPlayers if no team is selected
                LBXPlayers.Items.Clear();
            }
        }

        private void BTNWin_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected team
            string selectedTeam = LBXTeams.SelectedItem as string;

            // Display players of the selected team
            if (selectedTeam == t1.Name)
            {
                p1.ResultRecord = p1.ResultRecord.Remove(0, 1);
                p2.ResultRecord = p2.ResultRecord.Remove(0, 1);
                p3.ResultRecord = p3.ResultRecord.Remove(0, 1);
                p1.ResultRecord += "W";
                p2.ResultRecord += "W";
                p3.ResultRecord += "W";
                Calculate();

                LBXPlayers.Items.Clear();
                List<Player> players = t1.Players;
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord + " - " + player.Rating);
                }
            }
            else if (selectedTeam == t2.Name)
            {
                p4.ResultRecord = p4.ResultRecord.Remove(0, 1);
                p5.ResultRecord = p5.ResultRecord.Remove(0, 1);
                p6.ResultRecord = p6.ResultRecord.Remove(0, 1);
                p4.ResultRecord += "W";
                p5.ResultRecord += "W";
                p6.ResultRecord += "W";
                Calculate();

                LBXPlayers.Items.Clear();
                List<Player> players = t2.Players;
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord + " - " + player.Rating);
                }
            }
            else if (selectedTeam == t3.Name)
            {
                p7.ResultRecord = p7.ResultRecord.Remove(0, 1);
                p8.ResultRecord = p8.ResultRecord.Remove(0, 1);
                p9.ResultRecord = p9.ResultRecord.Remove(0, 1);
                p7.ResultRecord += "W";
                p8.ResultRecord += "W";
                p9.ResultRecord += "W";
                Calculate();

                LBXPlayers.Items.Clear();
                List<Player> players = t3.Players;
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord + " - " + player.Rating);
                }
            }
        }

        private void BTNDraw_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected team
            string selectedTeam = LBXTeams.SelectedItem as string;

            // Display players of the selected team
            if (selectedTeam == t1.Name)
            {
                p1.ResultRecord = p1.ResultRecord.Remove(0, 1);
                p2.ResultRecord = p2.ResultRecord.Remove(0, 1);
                p3.ResultRecord = p3.ResultRecord.Remove(0, 1);
                p1.ResultRecord += "D";
                p2.ResultRecord += "D";
                p3.ResultRecord += "D";
                Calculate();

                LBXPlayers.Items.Clear();
                List<Player> players = t1.Players;
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord + " - " + player.Rating);
                }
            }
            else if (selectedTeam == t2.Name)
            {
                p4.ResultRecord = p4.ResultRecord.Remove(0, 1);
                p5.ResultRecord = p5.ResultRecord.Remove(0, 1);
                p6.ResultRecord = p6.ResultRecord.Remove(0, 1);
                p4.ResultRecord += "D";
                p5.ResultRecord += "D";
                p6.ResultRecord += "D";
                Calculate();

                LBXPlayers.Items.Clear();
                List<Player> players = t2.Players;
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord + " - " + player.Rating);
                }
            }
            else if (selectedTeam == t3.Name)
            {
                p7.ResultRecord = p7.ResultRecord.Remove(0, 1);
                p8.ResultRecord = p8.ResultRecord.Remove(0, 1);
                p9.ResultRecord = p9.ResultRecord.Remove(0, 1);
                p7.ResultRecord += "D";
                p8.ResultRecord += "D";
                p9.ResultRecord += "D";
                Calculate();

                LBXPlayers.Items.Clear();
                List<Player> players = t3.Players;
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord + " - " + player.Rating);
                }
            }
        }

        private void BTNLose_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected team
            string selectedTeam = LBXTeams.SelectedItem as string;

            // Display players of the selected team
            if (selectedTeam == t1.Name)
            {
                p1.ResultRecord = p1.ResultRecord.Remove(0, 1);
                p2.ResultRecord = p2.ResultRecord.Remove(0, 1);
                p3.ResultRecord = p3.ResultRecord.Remove(0, 1);
                p1.ResultRecord += "L";
                p2.ResultRecord += "L";
                p3.ResultRecord += "L";
                Calculate();

                LBXPlayers.Items.Clear();
                List<Player> players = t1.Players;
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord + " - " + player.Rating);
                }
            }
            else if (selectedTeam == t2.Name)
            {
                p4.ResultRecord = p4.ResultRecord.Remove(0, 1);
                p5.ResultRecord = p5.ResultRecord.Remove(0, 1);
                p6.ResultRecord = p6.ResultRecord.Remove(0, 1);
                p4.ResultRecord += "L";
                p5.ResultRecord += "L";
                p6.ResultRecord += "L";
                Calculate();

                LBXPlayers.Items.Clear();
                List<Player> players = t2.Players;
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord + " - " + player.Rating);
                }
            }
            else if (selectedTeam == t3.Name)
            {
                p7.ResultRecord = p7.ResultRecord.Remove(0, 1);
                p8.ResultRecord = p8.ResultRecord.Remove(0, 1);
                p9.ResultRecord = p9.ResultRecord.Remove(0, 1);
                p7.ResultRecord += "L";
                p8.ResultRecord += "L";
                p9.ResultRecord += "L";
                Calculate();

                LBXPlayers.Items.Clear();
                List<Player> players = t3.Players;
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord + " - " + player.Rating);
                }
            }
        }
    }
}
