﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH11_CodeRefactoring.RefactoredCode
{
    internal class PetOwner
    {
        public void Walkies(IPet pet)
        {
            pet.Walkies();
        }
    }
}
