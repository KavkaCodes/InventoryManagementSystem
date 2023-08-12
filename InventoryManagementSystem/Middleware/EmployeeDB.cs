using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Castle.Core.Resource;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.ViewModel;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Middleware
{
    public  class EmployeeDB
    {
        private InventoryManagementContext contextInstance = null;
        private readonly IMapper mapper;

        public EmployeeDB()
        {
            mapper = MapperConfig.InitializeAutomapper();
        }

        public EmployeeDB(IMapper _mapper)
        {
            mapper = _mapper;
        }

        public EmployeeDTO GetEmployeeById(int Id)
        {
            contextInstance = new InventoryManagementContext();
            var employee = contextInstance.Employees.Where(i => i.EmployeeId == Id).FirstOrDefault();
            var newEmployee = mapper.Map<EmployeeDTO>(employee);

            return newEmployee;
        }

        public int AddEmployee(EmployeeDTO employee, out string errorMessage)
        {
            errorMessage = string.Empty;
            var response = 0;
            Employees newEmployee = null;

            try
            {
                newEmployee = mapper.Map<Employees>(employee);
                contextInstance = new InventoryManagementContext();
                contextInstance.Employees.Add(newEmployee);

                response = contextInstance.SaveChanges(true);
            }

            catch (DbUpdateConcurrencyException ex)
            {

                ex.Entries.Single().Reload();
                if (contextInstance.Entry(newEmployee).State == EntityState.Added)
                {
                    errorMessage += "Another user has Added that employee - Concurrency Error" + "\n";

                }
                else
                {
                    errorMessage += "Another user has Added that employee.\n" + "The current database values will be displayed.";
                }
            }
            catch (DbUpdateException ex)
            {
                //
                var sqlException = (SqlException)
                    ex.InnerException;

                foreach (SqlError error in sqlException.Errors)
                {
                    errorMessage += "ERROR CODE: " + error.Number + " " + error.Message + "\n";
                }
            }
            catch (Exception ex)
            {
                errorMessage += $"{ex.Message}, {ex.GetType().ToString()}";
            }
            return response;

        }
    }
}
