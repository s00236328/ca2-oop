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
        public MainWindow()
        {
            InitializeComponent();
            GetData();
        }

        public void GetData()
        {
            Team t1 = new Team() { Name = "France" };
            LBXTeams.Items.Add(t1.Name);
            Team t2 = new Team() { Name = "Italy" };
            LBXTeams.Items.Add(t2.Name);
            Team t3 = new Team() { Name = "Spain" };
            LBXTeams.Items.Add(t3.Name);
            //French players
            Player p1 = new Player() { Name = "Marie", ResultRecord = "WWDDL" };
            Player p2 = new Player() { Name = "Claude", ResultRecord = "DDDLW" };
            Player p3 = new Player() { Name = "Antoine", ResultRecord = "LWDLW" };
       
            //Italian players
            Player p4 = new Player() { Name = "Marco", ResultRecord = "WWDLL" };
            Player p5 = new Player() { Name = "Giovanni", ResultRecord = "LLLLD" };
            Player p6 = new Player() { Name = "Valentina", ResultRecord = "DLWWW" };

            //Spanish players
            Player p7 = new Player() { Name = "Maria", ResultRecord = "WWWWW" };
            Player p8 = new Player() { Name = "Jose", ResultRecord = "LLLLL" };
            Player p9 = new Player() { Name = "Pablo", ResultRecord = "DDDDD" };
            LBXPlayers.Items.Add(p1.Name + p1.ResultRecord);
            LBXPlayers.Items.Add(p2.Name + p2.ResultRecord);
            LBXPlayers.Items.Add(p3.Name + p3.ResultRecord);
            LBXPlayers.Items.Add(p4.Name + p4.ResultRecord);
            LBXPlayers.Items.Add(p5.Name + p5.ResultRecord);
            LBXPlayers.Items.Add(p6.Name + p6.ResultRecord);
            LBXPlayers.Items.Add(p7.Name + p7.ResultRecord);
            LBXPlayers.Items.Add(p8.Name + p8.ResultRecord);
            LBXPlayers.Items.Add(p9.Name + p9.ResultRecord);
        }
    }
}
