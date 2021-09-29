using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace JobApplicationsManagement
{
    public class JobApplication
    {
        public int JobApplicationId { get; set; }
        public virtual Employer Employer { get; set; }

        public DateTime ApplicationTime { get; set; }

        public string Comment { get; set; }

        public string Referrer { get; set; }

        public virtual ApplicationStatus Status { get; set; }

        public virtual ICollection<ApplicationEvent> Events { get; private set; } =
            new ObservableCollection<ApplicationEvent>();
    }

    public enum ApplicationStatus
    {
        InformationGathering,
        Applied,
        ApplicationAccepted,
        InterviewScheduled,
        WaitingForResponse,
        Accepted,
        Rejected

    }
}
