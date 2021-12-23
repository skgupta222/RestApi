﻿using RestService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestService.Services
{
    public class BusinessLogic : IBusinessLogic
    {
      
        public int GetSecondHighestInteger(RequestModel model)
        {
           return model.Data.ToList().OrderByDescending(x => x).Skip(1).First();
        }
    }
}