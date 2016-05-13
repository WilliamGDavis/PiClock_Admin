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
using System.Windows.Shapes;

namespace PiClock_Admin
{
    /// <summary>
    /// Interaction logic for UserManagement_Adduser.xaml
    /// </summary>
    public partial class UserManagement_Adduser : Window
    {
        public UserManagement_Adduser()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_AddUser_Click(object sender, RoutedEventArgs e)
        {
            //Check for empty textbox values
            if (textBox_Fname.Text == "" || textBox_Mname.Text == "" || textBox_Lname.Text == "" || textBox_Pin.Text == "" || textBox_PinConfirm.Text == "")
            { MessageBox.Show("Please fill in all textboxes"); return; }

            //Make sure PINs are the same
            if (textBox_Pin.Text != textBox_PinConfirm.Text)
            { MessageBox.Show("Please make sure PIN matches PIN (Confirm)"); return; }

            //TODO: Change this to a setting value instead of a hardcoded value
            //Check to ensure the PIN length matches what is saved in the settings
            int PinLength = 4;
            if (textBox_Pin.Text.Length != PinLength)
            { MessageBox.Show(String.Format("Please ensure the PIN Length is {0}", PinLength)); return; }

            //Ensure a user have only typed a numeric value into PIN and PIN (Confirm)
            if (false == isNumber(textBox_Pin.Text) || false == isNumber(textBox_PinConfirm.Text))
            { MessageBox.Show("Please enter only numeric values into PIN and PIN (Confirm)"); return; }

            //TODO: If all checks pass, check the Database for duplicate values

            //TODO: Add the user to the Database

            //If the user is added successfully, close out the form
            this.Close();
        }

        private Boolean isNumber(string value)
        {
            return value.All(Char.IsDigit);
        }
    }
}
