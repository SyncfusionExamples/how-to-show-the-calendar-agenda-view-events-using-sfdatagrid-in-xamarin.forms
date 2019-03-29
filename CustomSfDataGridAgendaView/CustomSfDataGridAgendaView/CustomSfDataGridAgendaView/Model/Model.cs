using System;
namespace CustomSfDataGridAgendaView
{
    public class Model
    {
        private int no;
        private string subject;
        private string starttime;
        private string endtime;

        public int No
        {
            get { return no; }
            set { this.no = value; }
        }

        public string Subject
        {
            get { return subject; }
            set { this.subject = value; }
        }

        public string StartTime
        {
            get { return starttime; }
            set { this.starttime = value; }
        }

        public string EndTime
        {
            get { return this.endtime; }
            set { this.endtime = value; }
        }

        public Model(int no, string subject, string starttime, string endtime)
        {
            this.No = no;
            this.Subject = subject;
            this.StartTime = starttime;
            this.EndTime = endtime;
        }
    }
}