using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum EmployeeType
    {
        Owner, Waiter, Bartender, Chef
    }

    public static class EmployeeTypeExtensions
    {
        public static string ToDutchString(this EmployeeType employeeType)
        {
            switch (employeeType)
            {
                case EmployeeType.Owner:
                        return "Eigenaar";
                case EmployeeType.Waiter:
                        return "Bediening";
                case EmployeeType.Bartender:
                        return "Barpersoneel";
                case EmployeeType.Chef:
                        return "Keukenpersoneel";
                default:
                    return "Onbekend";
            }
        }
    }
}
