﻿using System;
using System.Collections.Generic;
using System.Text;
using Emes.Core.Dtos;

namespace Emes.Erp.ISystem.Dtos.Users
{
   public class AuthUserDto : DtoBase
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}