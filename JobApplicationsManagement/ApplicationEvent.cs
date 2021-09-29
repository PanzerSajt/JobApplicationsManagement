using System;
namespace JobApplicationsManagement
{
    public class ApplicationEvent
    {
        public int ApplicationEventId { get; set; }
        public DateTime Time { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual JobApplication JobApplication { get; set; }
    }
}
