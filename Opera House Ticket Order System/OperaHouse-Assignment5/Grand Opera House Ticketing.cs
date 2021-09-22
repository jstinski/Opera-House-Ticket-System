using OperaHouse_Assignment5;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OperaHouse_Assignment4
{
    public partial class Form1 : Form
    {
        private Event eventSelection;

        public List<Event> events;

        private List<Event> eventSelectionTickets;

        public Form1()
        {
            InitializeComponent();
            events = new List<Event>();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventSelection = (Event)lstEvent.SelectedItem;
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            events.Sort();
            RefreshForm();
        }

        public void RefreshForm()
        {
            lstEvent.Items.Clear();
            foreach (Event e in events)
            {
                lstEvent.Items.Add(e);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEvent newEvent = new AddEvent(this);
            newEvent.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (eventSelection != null)
            {
                eventSelection = (Event)lstEvent.SelectedItem;
                events.Remove(eventSelection);
                RefreshForm();
            }
            else
            {
                MessageBox.Show("No input selected.");
            }
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            var eventClass = new EventList(events);
            eventClass.SortByTitle();
            RefreshForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (eventSelection != null)
            {
                EditEvent edit = new EditEvent(this, eventSelection);
                edit.Show();
            }
            else
            {
                MessageBox.Show("No input selected.");
            }
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            if (eventSelection != null)
            {
                /*
                eventSelectionTickets = eventSelection.tickets;
                TicketExchange te = new TicketExchange(this, eventSelectionTickets);
                
                te.ShowTickets();
                te.Show();
                */
            }
        }

        private void btnPerformer_Click(object sender, EventArgs e)
        {
            PerformerFilter filter = new PerformerFilter(this);
            filter.Show();
        }

        public void Update(List<Event> events)
        {
            lstEvent.Items.Clear();
            foreach (Event e in events)
            {
                lstEvent.Items.Add(e);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var eventListClass = new EventList(events);
            List<Event> openShows = eventListClass.OpenShows();
            Update(openShows);
        }

        private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventSelection = (Event)lstEvent.SelectedItem;
        }
    }
}
