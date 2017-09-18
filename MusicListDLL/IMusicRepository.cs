using MusicListEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicListDAL
{
    public interface IMusicRepository
    {
        Music GetMusic(int Id);
        List<Music> GetAllMusic();
        Music Add(Music music);
        Music Delete(int Id);
        //no Update because UnitOfWork will do update.
    }
}

