﻿using System;
using System.Collections.Generic;
using System.Text;
using Emes.Core.Dtos;

namespace Emes.Erp.ISystem.Dtos.Roles
{
    public class CreateRoleDto : DtoBase
    {
        public string Name { get; set; }
        public string Notes { get; set; }
    }
}
