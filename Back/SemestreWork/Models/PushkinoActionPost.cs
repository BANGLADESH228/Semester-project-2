﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SemestreWork.Models
{
    public class PushkinoActionPost
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Intro { get; set; }
        public string Text { get; set; }
        public string Picture { get; set; }
    }
}
