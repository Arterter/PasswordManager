﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordManager.Entities;

namespace PasswordManager.Data
{
    public class SettingsData
    {
        private static SettingsData _instance;

        protected SettingsData()
        {
        }

        public static SettingsData Instance()
        {
            if (_instance == null)
            {
                _instance = new SettingsData();
            }

            return _instance;
        }

        public bool Update(User user, Settings settings)
        {
            throw new NotImplementedException();
        }
    }
}
