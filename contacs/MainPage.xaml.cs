using contacs.Classes;
using System.ComponentModel;
using Xamarin.Forms;
using SQLite;

namespace contacs
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }


        private void SaveContactButton_Clicked(object sender, System.EventArgs e)
        {
            Contact contact = new Contact()
            {
                Name = nameEntry.Text,
                LastName = lastNameEtry.Text,
                PhoneNumber = phoneNumberEntry.Text,
                Email = emailEntry.Text,
                Adress = addressEntry.Text
            };

            using(SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Contact>();
                int rowsAdde = conn.Insert(contact);
            }

        }
    }
}
