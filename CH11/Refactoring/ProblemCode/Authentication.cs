﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CH11_CodeRefactoring.ProblemCode
{
    public class Authentication
    {
        private bool _isAuthenticated = false;

        public void Login(ICredentials credentials)
        {
            _isAuthenticated = true;
        }

        public void Logout()
        {
            _isAuthenticated = false;
        }

        public bool IsAuthenticated()
        {
            return _isAuthenticated;
        }
    }
}
