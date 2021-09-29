
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace JobApplicationsManagement
{
    public class Employer
    {
        public int EmployerId { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }

        public string FoundBy { get; set; }

        public virtual ICollection<JobApplication> JobApplications { get; private set; } =
            new ObservableCollection<JobApplication>();

    }
}
