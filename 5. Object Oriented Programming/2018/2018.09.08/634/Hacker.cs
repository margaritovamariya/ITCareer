﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _634
{
    public class Hacker
    {
        public string username = "securityGod82";
        private string password = "mySuperSecretPassw0rd";

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        private int Id { get; set; }

        public double BankAccountBalance { get; private set; }

        public void DownloadAllBankAccountsInTheWorld()
        {
        }
    }

}