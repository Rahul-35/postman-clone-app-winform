namespace PostmanCloneUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void apiClick_Click(object sender, EventArgs e)
        {

            //validate api url
            try
            {
                systemStatus.Text = "Calling API...";
                //sample code replace with actual API
                await Task.Delay(1000);
                systemStatus.Text = "Ready";
            }
            catch (Exception ex) 
            {
                resultsText.Text = "Error: "+ex.Message;
                systemStatus.Text = "Error";
            }
        }
    }
}
