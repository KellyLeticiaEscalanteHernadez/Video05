namespace Video05
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Presioine de nuevo";

        }
    }

}
