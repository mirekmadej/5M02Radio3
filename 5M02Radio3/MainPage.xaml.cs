namespace _5M02Radio3
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }
        private void rbChanged(object sender, EventArgs e)
        {
            if(rbRed.IsChecked)
                lblNapis.TextColor = Colors.Red;
            else if(rbGreen.IsChecked)
                lblNapis.TextColor= Colors.Green;
            else if(rbBlue.IsChecked)
                lblNapis.TextColor=(Colors.Blue);
        }
        
    }

}
