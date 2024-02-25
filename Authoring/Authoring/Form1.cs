using System.Windows.Forms;

namespace Authoring
{
    public partial class Form1 : Form
    {
        private Panel checkboxPanel;
        JsonReader jsonReader = new JsonReader();
        JsonUpdater jsonUpdater = new JsonUpdater();
        public Form1()
        {
            InitializeComponent();
            jsonReader.GetData(); // To Read data from json file and store the data.
            CreateCheckBox();
            AddingData();

        }

        void CreateCheckBox()
        {
            // To create Check Box Panel.
            checkboxPanel = new FlowLayoutPanel();
            checkboxPanel.Location = new System.Drawing.Point(700, 185);
            checkboxPanel.Size = new System.Drawing.Size(50, 500);
            checkboxPanel.BringToFront();

            this.Controls.Add(checkboxPanel);

        }

        private void AddTextToFlowLayoutPanel(string text)
        {
            Label label = new Label();
            label.Size = new System.Drawing.Size(211,26);
            label.Text = text;

            // Add the label to the FlowLayoutPanel.
            flowLayoutPanel1.BringToFront();
            flowLayoutPanel1.Controls.Add(label);
        }

        void AddingData()
        {
            for (int i = 0; i < jsonReader.assetNameList.Count; i++)
            {
                AddTextToFlowLayoutPanel(jsonReader.assetNameList[i]);
                CheckBox checkBox = new CheckBox();
                checkBox.Checked = false;
                checkBox.Margin = new Padding(0, 0, 0, 1);
                checkboxPanel.Controls.Add(checkBox);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<bool> defect = new List<bool>();
            foreach (Control control in checkboxPanel.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    defect.Add(checkBox.Checked);
                }
            }
            jsonUpdater.UpdateData(defect);

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in checkboxPanel.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
            }
        }
    }
}