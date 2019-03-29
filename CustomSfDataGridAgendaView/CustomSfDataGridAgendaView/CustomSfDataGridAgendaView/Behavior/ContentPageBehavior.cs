using System;
using System.Collections.ObjectModel;
using Syncfusion.SfCalendar.XForms;
using Xamarin.Forms;

namespace CustomSfDataGridAgendaView
{
    public class ContentPageBehavior : Behavior<ContentPage>
    {
        private SfCalendar calendar;
        private CalendarEventCollection calendarInlineEvents;
        private ObservableCollection<string> meetingSubjectCollection;
        private ObservableCollection<Color> colorCollection;
        public ContentPageBehavior()
        {
            calendarInlineEvents = new CalendarEventCollection();
            this.AddAppointmentDetails();
            this.AddAppointments();
        }

        protected override void OnAttachedTo(ContentPage bindable)
        {
            var page = bindable as Page;
            calendar = page.FindByName<SfCalendar>("Calendar");
            calendar.OnInlineLoaded += Calendar_OnInlineLoaded;
            // Setting Datasource for 3 Months.
            calendar.DataSource = calendarInlineEvents;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            calendar.OnInlineLoaded -= Calendar_OnInlineLoaded;
            base.OnDetachingFrom(bindable);
        }


        /// <summary>
        /// Adds the appointment details.
        /// </summary>
        private void AddAppointmentDetails()
        {
            meetingSubjectCollection = new ObservableCollection<string>();
            meetingSubjectCollection.Add("General Meeting");
            meetingSubjectCollection.Add("Plan Execution");
            meetingSubjectCollection.Add("Project Plan");
            meetingSubjectCollection.Add("Consulting");
            meetingSubjectCollection.Add("Support");
            meetingSubjectCollection.Add("Development Meeting");
            meetingSubjectCollection.Add("Scrum");
            meetingSubjectCollection.Add("Project Completion");
            meetingSubjectCollection.Add("Release updates");
            meetingSubjectCollection.Add("Performance Check");

            colorCollection = new ObservableCollection<Color>();
            colorCollection.Add(Color.FromHex("#FFA2C139"));
            colorCollection.Add(Color.FromHex("#FFD80073"));
            colorCollection.Add(Color.FromHex("#FF1BA1E2"));
            colorCollection.Add(Color.FromHex("#FFE671B8"));
            colorCollection.Add(Color.FromHex("#FFF09609"));
            colorCollection.Add(Color.FromHex("#FF339933"));
            colorCollection.Add(Color.FromHex("#FF00ABA9"));
            colorCollection.Add(Color.FromHex("#FFE671B8"));
            colorCollection.Add(Color.FromHex("#FF1BA1E2"));
            colorCollection.Add(Color.FromHex("#FFD80073"));
            colorCollection.Add(Color.FromHex("#FFA2C139"));
            colorCollection.Add(Color.FromHex("#FFA2C139"));
            colorCollection.Add(Color.FromHex("#FFD80073"));
            colorCollection.Add(Color.FromHex("#FF339933"));
            colorCollection.Add(Color.FromHex("#FFE671B8"));
            colorCollection.Add(Color.FromHex("#FF00ABA9"));
        }

        /// <summary>
        /// Adds the appointments.
        /// </summary>
        private void AddAppointments()
        {
            var today = DateTime.Now.Date;
            var random = new Random();
            for (int month = -1; month < 2; month++)
            {
                for (int day = -5; day < 5; day++)
                {
                    for (int count = 0; count < 2; count++)
                    {
                        var appointment = new CalendarInlineEvent();
                        appointment.Subject = meetingSubjectCollection[random.Next(7)];
                        appointment.Color = colorCollection[random.Next(10)];
                        appointment.StartTime = today.AddMonths(month).AddDays(random.Next(1, 28)).AddHours(random.Next(9, 18));
                        appointment.EndTime = appointment.StartTime.AddHours(2);
                        this.calendarInlineEvents.Add(appointment);
                    }
                }
            }
        }

        /// <summary>
        /// Calendars the on inline loaded.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="args">Arguments.</param>
        void Calendar_OnInlineLoaded(object sender, InlineEventArgs args)
        {
            ViewModel viewModel = new ViewModel();

            for (int i = 0; i < args.Appointments.Count; i++)
            {
                viewModel.EventCollection.Add(new Model(i + 1, args.Appointments[i].Subject, args.Appointments[i].StartTime.ToString("hh:mm tt"), args.Appointments[i].EndTime.ToString("hh:mm tt")));
            }
            if (args.Appointments.Count != 0)
            {
                args.View = new DataGrid() { BindingContext = viewModel };
            }
            else
            {
                var label = new Label();
                label.Text = "No Appointments";
                label.VerticalTextAlignment = TextAlignment.Start;
                label.HorizontalTextAlignment = TextAlignment.Start;
                label.HorizontalOptions = LayoutOptions.FillAndExpand;
                label.VerticalOptions = LayoutOptions.FillAndExpand;
                args.View = label;
            }

        }

    }
}
