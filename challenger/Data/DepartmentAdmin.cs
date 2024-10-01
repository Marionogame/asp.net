using challenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace challenger.Data
{
    public class DepartmentAdmin
    {
        public List<Department> GetData()
        {
            using (normal34dbEntities context = new normal34dbEntities())
            {

                return context.Department.AsNoTracking().ToList();

            }
        }
    }
}