﻿using HIMS.Model.IPD;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.IPD
{
   public interface I_pathologyReportDetail
    {
        public bool Insert(pathologyReportDetailParams pathologyReportDetailParams);

        public bool Update(pathologyReportDetailParams pathologyReportDetailParams);
    }
}
