
using System;
using System.Collections.Generic;
using System.Linq;
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
        Player p1 = new Player() { Name = "Marie", ResultRecord = "WWDDL" };
        Player p2 = new Player() { Name = "Claude", ResultRecord = "DDDLW" };
        Player p3 = new Player() { Name = "Antoine", ResultRecord = "LWDLW" };

        // Italian players
        Player p4 = new Player() { Name = "Marco", ResultRecord = "WWDLL" };
        Player p5 = new Player() { Name = "Giovanni", ResultRecord = "LLLLD" };
        Player p6 = new Player() { Name = "Valentina", ResultRecord = "DLWWW" };

        // Spanish players
        Player p7 = new Player() { Name = "Maria", ResultRecord = "WWWWW" };
        Player p8 = new Player() { Name = "Jose", ResultRecord = "LLLLL" };
        Player p9 = new Player() { Name = "Pablo", ResultRecord = "DDDDD" };

        public MainWindow()
        {
            InitializeComponent();
            GetData();
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

        private void LBXTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the selected team
            string selectedTeam = LBXTeams.SelectedItem as string;

            // Display players of the selected team
            if (selectedTeam == t1.Name)
            {
                List<Player> players = t1.Players;
                LBXPlayers.Items.Clear(); // Clear existing items
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord);
                }
            }
            else if (selectedTeam == t2.Name)
            {
                List<Player> players = t2.Players;
                LBXPlayers.Items.Clear(); // Clear existing items
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord);
                }
            }
            else if (selectedTeam == t3.Name)
            {
                List<Player> players = t3.Players;
                LBXPlayers.Items.Clear(); // Clear existing items
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord);
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

                LBXPlayers.Items.Clear();
                List<Player> players = t1.Players;
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord);
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

                LBXPlayers.Items.Clear();
                List<Player> players = t2.Players;
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord);
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

                LBXPlayers.Items.Clear();
                List<Player> players = t3.Players;
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord);
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

                LBXPlayers.Items.Clear();
                List<Player> players = t1.Players;
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord);
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

                LBXPlayers.Items.Clear();
                List<Player> players = t2.Players;
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord);
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

                LBXPlayers.Items.Clear();
                List<Player> players = t3.Players;
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord);
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

                LBXPlayers.Items.Clear();
                List<Player> players = t1.Players;
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord);
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

                LBXPlayers.Items.Clear();
                List<Player> players = t2.Players;
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord);
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

                LBXPlayers.Items.Clear();
                List<Player> players = t3.Players;
                foreach (Player player in players)
                {
                    LBXPlayers.Items.Add(player.Name + " - " + player.ResultRecord);
                }
            }
        }
    }
}
