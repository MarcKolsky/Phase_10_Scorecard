using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace Phase10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Global name variables
        /// </summary>
        public string player1Name;
        public string player2Name;
        public string player3Name;
        public string player4Name;
        public string player5Name;
        public string player6Name;
        public string player7Name;
        public string player8Name;

        public MainWindow()
        {
            InitializeComponent();


            ////  Sets the values for the score value listbox
            scoreValue.ItemsSource = new List<String> { "0", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90", "95", "100", "105", "110", "115", "120", "125", "130", "135", "140", "145", "150" };
        }



        /// <summary>
        ///  Launches a new instance of the add/remove form.
        /// </summary>
        private void AddRemovePlayers(object sender, RoutedEventArgs e)
        {
            Add_Remove_Players addRemovePlayers = new Add_Remove_Players();
            addRemovePlayers.ShowDialog();
        }



        /// <summary>
        ///  Resets the scorecard for a new game
        /// </summary>
        private void NewGameButton(object sender, RoutedEventArgs e)
        {

            if (Add_Remove_Players.player1NameTransfer.Trim() != String.Empty)
            {
                player1_Name.Visibility = Visibility.Visible;
                player1_ScoreList.Visibility = Visibility.Visible;
                player1_Total.Visibility = Visibility.Visible;
                player1_Total_Label.Visibility = Visibility.Visible;
                Border_1.Visibility = Visibility.Visible;
                Border_1_Bottom.Visibility = Visibility.Visible;
                Border_1_Top.Visibility = Visibility.Visible;
                player1_ScoreList_Level.Visibility = Visibility.Visible;
                currentLevelLabel1.Visibility = Visibility.Visible;

                player1_Name.Text = Add_Remove_Players.player1NameTransfer;

                player1_ScoreList.Items.Clear();
            }
            else
            {
                player1_Name.Visibility = Visibility.Hidden;
                player1_ScoreList.Visibility = Visibility.Hidden;
                player1_Total.Visibility = Visibility.Hidden;
                player1_Total_Label.Visibility = Visibility.Hidden;
                Border_1.Visibility = Visibility.Hidden;
                Border_1_Bottom.Visibility = Visibility.Hidden;
                Border_1_Top.Visibility = Visibility.Hidden;
                player1_ScoreList_Level.Visibility = Visibility.Hidden;
                currentLevelLabel1.Visibility = Visibility.Hidden;
            }

            if (Add_Remove_Players.player2NameTransfer.Trim() != String.Empty)
            {
                player2_Name.Visibility = Visibility.Visible;
                player2_ScoreList.Visibility = Visibility.Visible;
                player2_Total.Visibility = Visibility.Visible;
                player2_Total_Label.Visibility = Visibility.Visible;
                Border_2.Visibility = Visibility.Visible;
                Border_2_Bottom.Visibility = Visibility.Visible;
                Border_2_Top.Visibility = Visibility.Visible;
                player2_ScoreList_Level.Visibility = Visibility.Visible;
                currentLevelLabel2.Visibility = Visibility.Visible;

                player2_Name.Text = Add_Remove_Players.player2NameTransfer;

                player2_ScoreList.Items.Clear();
            }
            else
            {
                player2_Name.Visibility = Visibility.Hidden;
                player2_ScoreList.Visibility = Visibility.Hidden;
                player2_Total.Visibility = Visibility.Hidden;
                player2_Total_Label.Visibility = Visibility.Hidden;
                Border_2.Visibility = Visibility.Hidden;
                Border_2_Bottom.Visibility = Visibility.Hidden;
                Border_2_Top.Visibility = Visibility.Hidden;
                player2_ScoreList_Level.Visibility = Visibility.Hidden;
                currentLevelLabel2.Visibility = Visibility.Hidden;
            }

            if (Add_Remove_Players.player3NameTransfer.Trim() != String.Empty)
            {
                player3_Name.Visibility = Visibility.Visible;
                player3_ScoreList.Visibility = Visibility.Visible;
                player3_Total.Visibility = Visibility.Visible;
                player3_Total_Label.Visibility = Visibility.Visible;
                Border_3.Visibility = Visibility.Visible;
                Border_3_Bottom.Visibility = Visibility.Visible;
                Border_3_Top.Visibility = Visibility.Visible;
                player3_ScoreList_Level.Visibility = Visibility.Visible;
                currentLevelLabel3.Visibility = Visibility.Visible;

                player3_Name.Text = Add_Remove_Players.player3NameTransfer;

                player3_ScoreList.Items.Clear();
            }
            else
            {
                player3_Name.Visibility = Visibility.Hidden;
                player3_ScoreList.Visibility = Visibility.Hidden;
                player3_Total.Visibility = Visibility.Hidden;
                player3_Total_Label.Visibility = Visibility.Hidden;
                Border_3.Visibility = Visibility.Hidden;
                Border_3_Bottom.Visibility = Visibility.Hidden;
                Border_3_Top.Visibility = Visibility.Hidden;
                player3_ScoreList_Level.Visibility = Visibility.Hidden;
                currentLevelLabel3.Visibility = Visibility.Hidden;
            }

            if (Add_Remove_Players.player4NameTransfer.Trim() != String.Empty)
            {
                player4_Name.Visibility = Visibility.Visible;
                player4_ScoreList.Visibility = Visibility.Visible;
                player4_Total.Visibility = Visibility.Visible;
                player4_Total_Label.Visibility = Visibility.Visible;
                Border_4.Visibility = Visibility.Visible;
                Border_4_Bottom.Visibility = Visibility.Visible;
                Border_4_Top.Visibility = Visibility.Visible;
                player4_ScoreList_Level.Visibility = Visibility.Visible;
                currentLevelLabel4.Visibility = Visibility.Visible;

                player4_Name.Text = Add_Remove_Players.player4NameTransfer;

                player4_ScoreList.Items.Clear();
            }
            else
            {
                player4_Name.Visibility = Visibility.Hidden;
                player4_ScoreList.Visibility = Visibility.Hidden;
                player4_Total.Visibility = Visibility.Hidden;
                player4_Total_Label.Visibility = Visibility.Hidden;
                Border_4.Visibility = Visibility.Hidden;
                Border_4_Bottom.Visibility = Visibility.Hidden;
                Border_4_Top.Visibility = Visibility.Hidden;
                player4_ScoreList_Level.Visibility = Visibility.Hidden;
                currentLevelLabel4.Visibility = Visibility.Hidden;
            }

            if (Add_Remove_Players.player5NameTransfer.Trim() != String.Empty)
            {
                player5_Name.Visibility = Visibility.Visible;
                player5_ScoreList.Visibility = Visibility.Visible;
                player5_Total.Visibility = Visibility.Visible;
                player5_Total_Label.Visibility = Visibility.Visible;
                Border_5.Visibility = Visibility.Visible;
                Border_5_Bottom.Visibility = Visibility.Visible;
                Border_5_Top.Visibility = Visibility.Visible;
                player5_ScoreList_Level.Visibility = Visibility.Visible;
                currentLevelLabel5.Visibility = Visibility.Visible;

                player5_Name.Text = Add_Remove_Players.player5NameTransfer;

                player5_ScoreList.Items.Clear();
            }
            else
            {
                player5_Name.Visibility = Visibility.Hidden;
                player5_ScoreList.Visibility = Visibility.Hidden;
                player5_Total.Visibility = Visibility.Hidden;
                player5_Total_Label.Visibility = Visibility.Hidden;
                Border_5.Visibility = Visibility.Hidden;
                Border_5_Bottom.Visibility = Visibility.Hidden;
                Border_5_Top.Visibility = Visibility.Hidden;
                player5_ScoreList_Level.Visibility = Visibility.Hidden;
                currentLevelLabel5.Visibility = Visibility.Hidden;
            }

            if (Add_Remove_Players.player6NameTransfer.Trim() != String.Empty)
            {
                player6_Name.Visibility = Visibility.Visible;
                player6_ScoreList.Visibility = Visibility.Visible;
                player6_Total.Visibility = Visibility.Visible;
                player6_Total_Label.Visibility = Visibility.Visible;
                Border_6.Visibility = Visibility.Visible;
                Border_6_Bottom.Visibility = Visibility.Visible;
                Border_6_Top.Visibility = Visibility.Visible;
                player6_ScoreList_Level.Visibility = Visibility.Visible;
                currentLevelLabel6.Visibility = Visibility.Visible;

                player6_Name.Text = Add_Remove_Players.player6NameTransfer;

                player6_ScoreList.Items.Clear();
            }
            else
            {
                player6_Name.Visibility = Visibility.Hidden;
                player6_ScoreList.Visibility = Visibility.Hidden;
                player6_Total.Visibility = Visibility.Hidden;
                player6_Total_Label.Visibility = Visibility.Hidden;
                Border_6.Visibility = Visibility.Hidden;
                Border_6_Bottom.Visibility = Visibility.Hidden;
                Border_6_Top.Visibility = Visibility.Hidden;
                player6_ScoreList_Level.Visibility = Visibility.Hidden;
                currentLevelLabel6.Visibility = Visibility.Hidden;
            }

            if (Add_Remove_Players.player7NameTransfer.Trim() != String.Empty)
            {
                player7_Name.Visibility = Visibility.Visible;
                player7_ScoreList.Visibility = Visibility.Visible;
                player7_Total.Visibility = Visibility.Visible;
                player7_Total_Label.Visibility = Visibility.Visible;
                Border_7.Visibility = Visibility.Visible;
                Border_7_Bottom.Visibility = Visibility.Visible;
                Border_7_Top.Visibility = Visibility.Visible;
                player7_ScoreList_Level.Visibility = Visibility.Visible;
                currentLevelLabel7.Visibility = Visibility.Visible;

                player7_Name.Text = Add_Remove_Players.player7NameTransfer;

                player7_ScoreList.Items.Clear();
            }
            else
            {
                player7_Name.Visibility = Visibility.Hidden;
                player7_ScoreList.Visibility = Visibility.Hidden;
                player7_Total.Visibility = Visibility.Hidden;
                player7_Total_Label.Visibility = Visibility.Hidden;
                Border_7.Visibility = Visibility.Hidden;
                Border_7_Bottom.Visibility = Visibility.Hidden;
                Border_7_Top.Visibility = Visibility.Hidden;
                player7_ScoreList_Level.Visibility = Visibility.Hidden;
                currentLevelLabel7.Visibility = Visibility.Hidden;
            }

            if (Add_Remove_Players.player8NameTransfer.Trim() != String.Empty)
            {
                player8_Name.Visibility = Visibility.Visible;
                player8_ScoreList.Visibility = Visibility.Visible;
                player8_Total.Visibility = Visibility.Visible;
                player8_Total_Label.Visibility = Visibility.Visible;
                Border_8.Visibility = Visibility.Visible;
                Border_8_Bottom.Visibility = Visibility.Visible;
                Border_8_Top.Visibility = Visibility.Visible;
                player8_ScoreList_Level.Visibility = Visibility.Visible;
                currentLevelLabel8.Visibility = Visibility.Visible;

                player8_Name.Text = Add_Remove_Players.player8NameTransfer;

                player8_ScoreList.Items.Clear();
            }
            else
            {
                player8_Name.Visibility = Visibility.Hidden;
                player8_ScoreList.Visibility = Visibility.Hidden;
                player8_Total.Visibility = Visibility.Hidden;
                player8_Total_Label.Visibility = Visibility.Hidden;
                Border_8.Visibility = Visibility.Hidden;
                Border_8_Bottom.Visibility = Visibility.Hidden;
                Border_8_Top.Visibility = Visibility.Hidden;
                player8_ScoreList_Level.Visibility = Visibility.Hidden;
                currentLevelLabel8.Visibility = Visibility.Hidden;
            }

            LastMove.Clear();
        }



        ListBox dragSource = null;


        /// <summary>
        ///  Linked to the scoreValue listbox, this is the method that interprets when a value in the listbox is clicked on and dragged out of the listbox.
        /// </summary>
        private void ListBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListBox parent = (ListBox)sender;
            dragSource = parent;
            object data = GetDataFromListBox(dragSource, e.GetPosition(parent));

            if (data != null)
            {
                DragDrop.DoDragDrop(parent, data, DragDropEffects.Copy);
            }
        }



        /// <summary>
        ///  When a value us selected and dragged out of the scoreValue listbox, this method captures that value and passes it the listbox it's dropped into.
        /// </summary>
        private static object GetDataFromListBox(ListBox source, Point point)
        {
            UIElement element = source.InputHitTest(point) as UIElement;
            if (element != null)
            {
                object data = DependencyProperty.UnsetValue;
                while (data == DependencyProperty.UnsetValue)
                {
                    data = source.ItemContainerGenerator.ItemFromContainer(element);

                    if (data == DependencyProperty.UnsetValue)
                    {
                        element = VisualTreeHelper.GetParent(element) as UIElement;
                    }

                    if (element == source)
                    {
                        return null;
                    }
                }

                if (data != DependencyProperty.UnsetValue)
                {
                    return data;
                }
            }

            return null;
        }




        /// <summary>
        ///  This method identifies which player's score list the value dragged from the scoreValue listbox is dropped into.
        ///  If the score is <= 45, then the players level indicator will increase by one automatically.
        /// </summary>
        private void ListBox_Drop(object sender, DragEventArgs e)
        {
            ListBox parent = (ListBox)sender;

            object data = e.Data.GetData(typeof(string));
            parent.Items.Add(data);

            ListBoxAutomationPeer svAutomation = (ListBoxAutomationPeer)ScrollViewerAutomationPeer.CreatePeerForElement(parent);

            IScrollProvider scrollInterface = (IScrollProvider)svAutomation.GetPattern(PatternInterface.Scroll);
            System.Windows.Automation.ScrollAmount scrollVertical = System.Windows.Automation.ScrollAmount.LargeIncrement;
            System.Windows.Automation.ScrollAmount scrollHorizontal = System.Windows.Automation.ScrollAmount.NoAmount;


            ////  This will keep the vertical scroll bar set down to always show the last score entered at the bottom of the listbox. 
            if (scrollInterface.VerticallyScrollable)
                scrollInterface.Scroll(scrollHorizontal, scrollVertical);



            int lastIndex = parent.Items.Count - 1;         ////  Counts how many items are in the listbox, and subtracts the number to identify the last index number.

            int lastIndexValue = Convert.ToInt32(parent.Items[lastIndex]);      //// Sets the last index value where the score will be added to the players listbox.

            if (parent.Name == "player1_ScoreList")
            {
                if (lastIndexValue <= 45)
                {
                    player1_ScoreList_Level.Text = (int.Parse(player1_ScoreList_Level.Text) + 1).ToString();
                }

                int i = 0, result = 0;
                while (i < player1_ScoreList.Items.Count)
                {
                    result += Convert.ToInt32(player1_ScoreList.Items[i++]);
                }

                player1_Total.Text = Convert.ToString(result);
            }
            else if (parent.Name == "player2_ScoreList")
            {
                if (lastIndexValue <= 45)
                {
                    player2_ScoreList_Level.Text = (int.Parse(player2_ScoreList_Level.Text) + 1).ToString();
                }

                int i = 0, result = 0;
                while (i < player2_ScoreList.Items.Count)
                {
                    result += Convert.ToInt32(player2_ScoreList.Items[i++]);
                }

                player2_Total.Text = Convert.ToString(result);
            }
            else if (parent.Name == "player3_ScoreList")
            {
                if (lastIndexValue <= 45)
                {
                    player3_ScoreList_Level.Text = (int.Parse(player3_ScoreList_Level.Text) + 1).ToString();
                }

                int i = 0, result = 0;
                while (i < player3_ScoreList.Items.Count)
                {
                    result += Convert.ToInt32(player3_ScoreList.Items[i++]);
                }

                player3_Total.Text = Convert.ToString(result);
            }
            else if (parent.Name == "player4_ScoreList")
            {
                if (lastIndexValue <= 45)
                {
                    player4_ScoreList_Level.Text = (int.Parse(player4_ScoreList_Level.Text) + 1).ToString();
                }

                int i = 0, result = 0;
                while (i < player4_ScoreList.Items.Count)
                {
                    result += Convert.ToInt32(player4_ScoreList.Items[i++]);
                }

                player4_Total.Text = Convert.ToString(result);
            }
            else if (parent.Name == "player5_ScoreList")
            {
                if (lastIndexValue <= 45)
                {
                    player5_ScoreList_Level.Text = (int.Parse(player5_ScoreList_Level.Text) + 1).ToString();
                }

                int i = 0, result = 0;
                while (i < player5_ScoreList.Items.Count)
                {
                    result += Convert.ToInt32(player5_ScoreList.Items[i++]);
                }

                player5_Total.Text = Convert.ToString(result);
            }
            else if (parent.Name == "player6_ScoreList")
            {
                if (lastIndexValue <= 45)
                {
                    player6_ScoreList_Level.Text = (int.Parse(player6_ScoreList_Level.Text) + 1).ToString();
                }

                int i = 0, result = 0;
                while (i < player6_ScoreList.Items.Count)
                {
                    result += Convert.ToInt32(player6_ScoreList.Items[i++]);
                }

                player6_Total.Text = Convert.ToString(result);
            }
            else if (parent.Name == "player7_ScoreList")
            {
                if (lastIndexValue <= 45)
                {
                    player7_ScoreList_Level.Text = (int.Parse(player7_ScoreList_Level.Text) + 1).ToString();
                }

                int i = 0, result = 0;
                while (i < player7_ScoreList.Items.Count)
                {
                    result += Convert.ToInt32(player7_ScoreList.Items[i++]);
                }

                player7_Total.Text = Convert.ToString(result);
            }
            else if (parent.Name == "player8_ScoreList")
            {
                if (lastIndexValue <= 45)
                {
                    player8_ScoreList_Level.Text = (int.Parse(player8_ScoreList_Level.Text) + 1).ToString();
                }

                int i = 0, result = 0;
                while (i < player8_ScoreList.Items.Count)
                {
                    result += Convert.ToInt32(player8_ScoreList.Items[i++]);
                }

                player8_Total.Text = Convert.ToString(result);
            }

            LastMove.Add(parent.Name);          ////  Adds the player's name to the LastMove list.
        }

        List<string> LastMove = new List<string>();             ////  The list that stores every move in a game for the undo botton.



        /// <summary>
        ///  This method operates the undo button, and reads from the LastMove list.
        /// </summary>
        private void Undo(object sender, RoutedEventArgs e)
        {
            if (LastMove.Count != 0)
            {
                string lastItem = LastMove[LastMove.Count - 1].ToString();          ////  Retrieves the last move from the LastMove list, and converts it to a string.


                ////  Removes the last score from a player's score list according to how they were added to the LastMove list.
                if (lastItem == "player1_ScoreList")
                {
                    int value1 = Convert.ToInt32(player1_ScoreList.Items[player1_ScoreList.Items.Count - 1].ToString());
                    if (value1 <= 45)
                    {
                        player1_ScoreList_Level.Text = (int.Parse(player1_ScoreList_Level.Text) - 1).ToString();
                    }
                    player1_ScoreList.Items.Remove(player1_ScoreList.Items[player1_ScoreList.Items.Count - 1]);

                    int i = 0, result = 0;
                    while (i < player1_ScoreList.Items.Count)
                    {
                        result += Convert.ToInt32(player1_ScoreList.Items[i++]);
                    }

                    player1_Total.Text = Convert.ToString(result);
                }
                else if (lastItem == "player2_ScoreList")
                {
                    int value2 = Convert.ToInt32(player2_ScoreList.Items[player2_ScoreList.Items.Count - 1].ToString());
                    if (value2 <= 45)
                    {
                        player2_ScoreList_Level.Text = (int.Parse(player2_ScoreList_Level.Text) - 1).ToString();
                    }
                    player2_ScoreList.Items.Remove(player2_ScoreList.Items[player2_ScoreList.Items.Count - 1]);

                    int i = 0, result = 0;
                    while (i < player2_ScoreList.Items.Count)
                    {
                        result += Convert.ToInt32(player2_ScoreList.Items[i++]);
                    }

                    player2_Total.Text = Convert.ToString(result);
                }
                else if (lastItem == "player3_ScoreList")
                {
                    int value3 = Convert.ToInt32(player3_ScoreList.Items[player3_ScoreList.Items.Count - 1].ToString());
                    if (value3 <= 45)
                    {
                        player3_ScoreList_Level.Text = (int.Parse(player3_ScoreList_Level.Text) - 1).ToString();
                    }
                    player3_ScoreList.Items.Remove(player3_ScoreList.Items[player3_ScoreList.Items.Count - 1]);

                    int i = 0, result = 0;
                    while (i < player3_ScoreList.Items.Count)
                    {
                        result += Convert.ToInt32(player3_ScoreList.Items[i++]);
                    }

                    player3_Total.Text = Convert.ToString(result);
                }
                else if (lastItem == "player4_ScoreList")
                {
                    int value4 = Convert.ToInt32(player4_ScoreList.Items[player4_ScoreList.Items.Count - 1].ToString());
                    if (value4 <= 45)
                    {
                        player4_ScoreList_Level.Text = (int.Parse(player4_ScoreList_Level.Text) - 1).ToString();
                    }
                    player4_ScoreList.Items.Remove(player4_ScoreList.Items[player4_ScoreList.Items.Count - 1]);

                    int i = 0, result = 0;
                    while (i < player4_ScoreList.Items.Count)
                    {
                        result += Convert.ToInt32(player4_ScoreList.Items[i++]);
                    }

                    player4_Total.Text = Convert.ToString(result);
                }
                else if (lastItem == "player5_ScoreList")
                {
                    int value5 = Convert.ToInt32(player5_ScoreList.Items[player5_ScoreList.Items.Count - 1].ToString());
                    if (value5 <= 45)
                    {
                        player5_ScoreList_Level.Text = (int.Parse(player5_ScoreList_Level.Text) - 1).ToString();
                    }
                    player5_ScoreList.Items.Remove(player5_ScoreList.Items[player5_ScoreList.Items.Count - 1]);

                    int i = 0, result = 0;
                    while (i < player5_ScoreList.Items.Count)
                    {
                        result += Convert.ToInt32(player5_ScoreList.Items[i++]);
                    }

                    player5_Total.Text = Convert.ToString(result);
                }
                else if (lastItem == "player6_ScoreList")
                {
                    int value6 = Convert.ToInt32(player6_ScoreList.Items[player6_ScoreList.Items.Count - 1].ToString());
                    if (value6 <= 45)
                    {
                        player6_ScoreList_Level.Text = (int.Parse(player6_ScoreList_Level.Text) - 1).ToString();
                    }
                    player6_ScoreList.Items.Remove(player6_ScoreList.Items[player6_ScoreList.Items.Count - 1]);

                    int i = 0, result = 0;
                    while (i < player6_ScoreList.Items.Count)
                    {
                        result += Convert.ToInt32(player6_ScoreList.Items[i++]);
                    }

                    player6_Total.Text = Convert.ToString(result);
                }
                else if (lastItem == "player7_ScoreList")
                {
                    int value7 = Convert.ToInt32(player7_ScoreList.Items[player7_ScoreList.Items.Count - 1].ToString());
                    if (value7 <= 45)
                    {
                        player7_ScoreList_Level.Text = (int.Parse(player7_ScoreList_Level.Text) - 1).ToString();
                    }
                    player7_ScoreList.Items.Remove(player7_ScoreList.Items[player7_ScoreList.Items.Count - 1]);

                    int i = 0, result = 0;
                    while (i < player7_ScoreList.Items.Count)
                    {
                        result += Convert.ToInt32(player7_ScoreList.Items[i++]);
                    }

                    player7_Total.Text = Convert.ToString(result);
                }
                else if (lastItem == "player8_ScoreList")
                {
                    int value8 = Convert.ToInt32(player8_ScoreList.Items[player8_ScoreList.Items.Count - 1].ToString());
                    if (value8 <= 45)
                    {
                        player8_ScoreList_Level.Text = (int.Parse(player8_ScoreList_Level.Text) - 1).ToString();
                    }
                    player8_ScoreList.Items.Remove(player8_ScoreList.Items[player8_ScoreList.Items.Count - 1]);

                    int i = 0, result = 0;
                    while (i < player8_ScoreList.Items.Count)
                    {
                        result += Convert.ToInt32(player8_ScoreList.Items[i++]);
                    }

                    player8_Total.Text = Convert.ToString(result);
                }

                LastMove.RemoveAt(LastMove.Count - 1);          ////  Removes the last item from the LastMove list to keep it current.
            }
            else
            {
                ////  If there is nothing in the LastMove list, then nothing will be undone.
                System.Windows.Forms.MessageBox.Show("Nothing To Undo");
            }
        }
    }
}
