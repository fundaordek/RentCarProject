﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public class IBrandService
    {
        List<Brand> GetAll();
        Brand GetById(int brandId);
    }
}