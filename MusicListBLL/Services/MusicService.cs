using System;
using System.Collections.Generic;
using System.Text;
using MusicListEntities;
using MusicListDAL;
using System.Linq;

namespace MusicListBLL.Services
{
    public class MusicService : IMusicService
    {
        IMusicRepository repo;

        public MusicService(IMusicRepository repo)
        {
            this.repo = repo;
        }
        public Music Add(Music music)
        {
            return repo.Add(music);
        }

        public Music Delete(int Id)
        {
            return repo.Delete(Id);
        }
        public Music Edit(Music music)
        {
            var musicFromDb = GetMusic(music.Id);
            if (musicFromDb == null)
            {
                throw new InvalidOperationException("Music not found");
            }
            musicFromDb.Name = music.Name;
            musicFromDb.Style = music.Style;
            return musicFromDb;
        }

        public List<Music> GetAllMusic()
        {
            return repo.GetAllMusic();
        } 
        public Music GetMusic(int Id)
        {
            return repo.GetMusic(Id);
        }
    }
}
