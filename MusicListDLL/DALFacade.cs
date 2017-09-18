﻿using MusicListDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicListDAL
{
    public class DALFacade
    {
        public IMusicRepository MusicRepository
        {
            get { return new MusicRepositoriesFakeDB(); }
        }
    }
}
