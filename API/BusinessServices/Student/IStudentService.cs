﻿using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
  public  interface IStudentService
    {
      List <StudentDetails> GetStudentById(int StudentId);
    }
}