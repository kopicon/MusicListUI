﻿using System;

namespace MusicListBLL.BusinessObjects
{
    public class MusicBO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Style { get; set; }

        public string FullName
        {
            get { return $"{Name} {Style}"; }
        }
    }
}
