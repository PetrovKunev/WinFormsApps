namespace LightToggleText
{
    public partial class ToggleText : Form
    {
        bool LightOn = false;
        public ToggleText()
        {
            InitializeComponent();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            LightOn = !LightOn;

            if (LightOn)
            {
                lblText.Text = "Light is on";
            }
            else
            {
                lblText.Text = "Light is off";
            }
        }
    }
}
