using PostmanCloneLibrary;

namespace PostmanCloneUI
{
    public partial class Dashboard : Form
    {
        private readonly IApiAccess _api = new ApiAccess();
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void apiClick_Click(object sender, EventArgs e)
        {
            systemStatus.Text = "Calling API...";
            resultsText.Text = null;
            //validate api url
            if (_api.isValidUrl(apiText.Text)==false)
            {
                systemStatus.Text = "Invalid URL";
                return;
            }
            try
            {
                //sample code replace with actual API
                resultsText.Text = await _api.CallApiAsync(apiText.Text);
                await Task.Delay(1000);
                systemStatus.Text = "Ready";
            }
            catch (Exception ex)
            {
                resultsText.Text = "Error: " + ex.Message;
                systemStatus.Text = "Error";
            }
        }

    }
}
