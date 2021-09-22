using OperaHouse_Assignment5;
using System;
using System.Windows.Forms;

namespace OperaHouse_Assignment4
{
    public partial class AddEvent : Form
    {
        private Form1 parent;

        public Performer performer;

        public AddEvent()
        {
            InitializeComponent();
        }

        public AddEvent(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string Title = txtTitle.Text;
            int numTickets = Convert.ToInt32(txtTIckets.Text);
            int eventLength = Convert.ToInt32(txtLength.Text);
            double ticketPrice = Convert.ToDouble(txtPrice.Text);
            DateTime eventTime = Convert.ToDateTime(txtDate.Text);
            bool concessionSales = true;

            performer = new Performer(txtPerformer.Text, eventLength);
            Event newEvent = new Event(ID, Title, performer, numTickets, ticketPrice, eventTime, eventLength, concessionSales);

            var eventClass = new EventList(parent.events);
            eventClass.AddEvent(newEvent);

            parent.RefreshForm();
            txtDate.Clear();
            txtID.Clear();
            txtPerformer.Clear();
            txtTitle.Clear();
            txtTIckets.Clear();
            txtLength.Clear();
            txtPrice.Clear();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
