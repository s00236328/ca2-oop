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
        }
    }
}
