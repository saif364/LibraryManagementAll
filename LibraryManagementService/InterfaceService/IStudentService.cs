﻿using LibraryManagementModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementService.InterfaceService
{
    public interface IStudentService:IBaseService<Student>
    {
        Task AddAsyncWithAT(Student student);
        Task UpdateAsyncWithAT(Student student);
    }
}
