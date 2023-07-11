using C63_Streamish.Models;
using System;
using System.Collections.Generic;

namespace C63_Streamish.Repositories
{
    public interface IVideoRepository
    {
        void Add(Video video);
        void Delete(int id);
        List<Video> GetAll();
        List<Video> GetAllWithComments();
        Video GetById(int id);
        Video GetVideoByIdWithComments(int id);
        List<Video> GetHottestVideos(DateTime since);
        List<Video> Search(string criterion, bool sortDescending);
        void Update(Video video);
    }
}