﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ReproForSelectManyEfBug
{
    public class Parent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Child> Children { get; set; }
    }
}
