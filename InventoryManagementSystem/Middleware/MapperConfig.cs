using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Castle.Core.Resource;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.ViewModel;

namespace InventoryManagementSystem.Middleware
{
    public class MapperConfig : Profile
    {
        public static Mapper InitializeAutomapper()
        {
            //Provide all the Mapping Configuration
            var config = new MapperConfiguration(cfg =>
            {
                //Configuring Customers and CustomerDTO
                cfg.CreateMap<Employees, EmployeeDTO>().ReverseMap();
                

                //  cfg.CreateMap<CustomerDTO, Customers>();
                //Any Other Mapping Configuration ....
            });
            //Create an Instance of Mapper and return that Instance
            var mapper = new Mapper(config);
            return mapper;
        }
    }
}
