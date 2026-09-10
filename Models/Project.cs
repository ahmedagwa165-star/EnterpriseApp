namespace EnterpriseApp.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public ICollection<EmployeeProject> EmployeeProjects { get; set; }
    }
}