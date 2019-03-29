using System;
using System.Collections.ObjectModel;

namespace CustomSfDataGridAgendaView
{
    public class ViewModel
    {
        private ObservableCollection<Model> eventCollection = new ObservableCollection<Model>();
        public ViewModel()
        {
        }

        /// <summary>
        /// Gets or sets the event collection.
        /// </summary>
        /// <value>The event collection.</value>
        public ObservableCollection<Model> EventCollection
        {
            get { return eventCollection; }
            set { this.eventCollection = value; }
        }
    }
}
