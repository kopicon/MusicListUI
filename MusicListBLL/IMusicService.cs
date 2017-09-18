using System;
using System.Collections.Generic;
using System.Text;
using MusicListEntities;

namespace MusicListBLL
{
    public interface IMusicService
    {
        Music GetMusic(int Id);
        List<Music> GetAllMusic();
        Music Add(Music music);
        Music Delete(int Id);
        Music Edit(Music music);    
    }
}
