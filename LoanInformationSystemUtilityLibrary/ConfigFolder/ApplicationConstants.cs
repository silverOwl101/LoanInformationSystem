﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanInformationSystemUtilityLibrary.ConfigFolder
{
    public static class ApplicationConstants
    {
        public static readonly string APP_DATA_SYSTEM_FOLDER = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Loan-Information-System");

        public static readonly string CONFIG_PATH = Path.Combine(APP_DATA_SYSTEM_FOLDER, "config.json");
    }
}
