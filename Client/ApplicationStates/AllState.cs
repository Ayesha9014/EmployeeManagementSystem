namespace Client.ApplicationStates
{
    public class AllState
    {
        public Action? Action { get; set; }
        //for general department
        public bool ShowGeneralDepartment { get; set; }
        public void GeneralDepartmentClicked()
        {
            ResetAllDepartments();
            ShowGeneralDepartment = true;
            Action?.Invoke();
        }

        //for department
        public bool ShowDepartment {  get; set; }
        public void DepartmentClicked()
        {
            ResetAllDepartments();
            ShowDepartment = true;
            Action?.Invoke();
        }

        //for branch
        public bool ShowBranch {  get; set; }
        public void BranchClicked()
        {
            ResetAllDepartments();
            ShowBranch = true;
            Action?.Invoke();
        }

        //for country
        public bool ShowCountry {  get; set; }
        public void CountryClicked()
        {
            ResetAllDepartments();
            ShowCountry = true;
            Action?.Invoke();
        }

        //for city
        public bool ShowCity { get; set; }
        public void CityClicked()
        {
            ResetAllDepartments();
            ShowCity = true;
            Action?.Invoke();
        }

        //for town
        public bool ShowTown { get; set; }
        public void TownClicked()
        {
            ResetAllDepartments();
            ShowTown = true;
            Action?.Invoke();
        }

        //User
        public bool ShowUser { get; set; }
        public void UserClicked()
        {
            ResetAllDepartments();
            ShowUser = true;
            Action?.Invoke();
        }

        //Doctor
        public bool ShowHealth { get; set; }
        public void HealthClicked()
        {
            ResetAllDepartments();
            ShowHealth = true;
            Action?.Invoke();
        }

        //Overtime
        public bool ShowOvertime { get; set; }
        public void OvertimeClicked()
        {
            ResetAllDepartments();
            ShowOvertime = true;
            Action?.Invoke();
        }

        //overtime type
        public bool ShowOvertimeType { get; set; }
        public void OvertimeTypeClicked()
        {
            ResetAllDepartments();
            ShowOvertimeType = true;
            Action?.Invoke();
        }

        //sanction
        public bool ShowSanction { get; set; }
        public void SanctionClicked()
        {
            ResetAllDepartments();
            ShowSanction = true;
            Action?.Invoke();
        }

        //sanctiontype
        public bool ShowSanctionType { get; set; }
        public void SanctionTypeClicked()
        {
            ResetAllDepartments();
            ShowSanctionType = true;
            Action?.Invoke();
        }

        //vacation
        public bool ShowVacation { get; set; }
        public void VacationClicked()
        {
            ResetAllDepartments();
            ShowVacation = true;
            Action?.Invoke();
        }

        //vacation type
        public bool ShowVacationType { get; set; }
        public void VacationTypeClicked()
        {
            ResetAllDepartments();
            ShowVacationType = true;
            Action?.Invoke();
        }

        //for Employee
        public bool ShowEmployee { get; set; } = true;
        public void EmployeeClicked()
        {
            ResetAllDepartments();
            ShowEmployee = true;
            Action?.Invoke();
        }

        //profile
        public bool ShowUserProfile { get; set; }
        public void UserProfileClicked()
        {
            ResetAllDepartments();
            ShowUserProfile = true;
            Action?.Invoke();
        }

        private void ResetAllDepartments()
        {
            ShowGeneralDepartment=false;
            ShowDepartment=false;
            ShowBranch=false;
            ShowCountry=false;
            ShowCity=false;
            ShowTown=false;
            ShowUser=false;
            ShowEmployee=false;
            ShowHealth=false;
            ShowOvertime=false;
            ShowOvertimeType=false;
            ShowSanction=false;
            ShowSanctionType=false;
            ShowVacation=false;
            ShowVacationType=false;
            ShowUserProfile=false;
        }
    }
}
