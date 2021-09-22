using OperaHouse_Assignment5;
using System;
using System.Windows.Forms;

namespace OperaHouse_Assignment4
{
    public partial class EditEvent : Form
    {
        private Form1 parent;

        private Event eventSelection;

        public Performer performer;
        public EditEvent()
        {
            InitializeComponent();
        }
        public EditEvent(Form1 parent, Event eventSelection)
        {
            InitializeComponent();
            this.parent = parent;
            this.eventSelection = eventSelection;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //eventSelection.ID = txtID.Text; no need to edit ID
            eventSelection.Title = txtTitle.Text;
            eventSelection.Performer.Name = txtPerformer.Text;
            //eventSelection.EventTime = Convert.ToDateTime(txtDate.Text);
            //eventSelection.DurationMinutes = Convert.ToInt32(txtLength.Text);
            eventSelection.EventTime = DateTime.Parse(txtDate.Text);
            eventSelection.DurationMinutes = int.Parse(txtLength.Text);

            parent.RefreshForm();
            this.Close();
        }
    }
}
