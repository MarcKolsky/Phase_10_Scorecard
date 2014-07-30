using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Phase10
{
    /// <summary>
    /// Interaction logic for Add_Remove_Players.xaml
    /// </summary>
    public partial class Add_Remove_Players : Window
    {
        /// <summary>
        ///  Set static variables to be accessed from the main window.
        /// </summary>
        public static string player1NameTransfer;
        public static string player2NameTransfer;
        public static string player3NameTransfer;
        public static string player4NameTransfer;
        public static string player5NameTransfer;
        public static string player6NameTransfer;
        public static string player7NameTransfer;
        public static string player8NameTransfer;


        public Add_Remove_Players()
        {
            InitializeComponent();            
        }


        /// <summary>
        ///  On click, this method reads the textboxes and sets a value to the static variables.
        /// </summary>
        public void PlayerNames(object sender, RoutedEventArgs e)
        {

            if (player1.ToString().Trim() != null)
            {
                player1NameTransfer = player1.Text;
            }

            if (player2.ToString().Trim() != null)
            {
                player2NameTransfer = player2.Text;
            }

            if (player3.ToString().Trim() != null)
            {
                player3NameTransfer = player3.Text;
            }

            if (player4.ToString().Trim() != null)
            {
                player4NameTransfer = player4.Text;
            }

            if (player5.ToString().Trim() != null)
            {
                player5NameTransfer = player5.Text;
            }

            if (player6.ToString().Trim() != null)
            {
                player6NameTransfer = player6.Text;
            }

            if (player7.ToString().Trim() != null)
            {
                player7NameTransfer = player7.Text;
            }

            if (player8.ToString().Trim() != null)
            {
                player8NameTransfer = player8.Text;
            }

            this.Close();           //// Closes this window and returns user to the main window.
        }
    }
}
