using System;
using System.Collections.Generic;
using System.Text;
using MusicListBLL.Services;
using MusicListDAL;

namespace MusicListBLL
{
    public class BLLFacade
    {
        public IMusicService GetMusicService()
        {
            return new MusicService(new DALFacade().MusicRepository);
        }
    }
}
