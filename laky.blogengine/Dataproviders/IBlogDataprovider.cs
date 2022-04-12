using Laky.Blogengine.Models;
using System.Collections.Generic;

namespace Laky.Blogengine.Dataproviders
{
    public interface IBlogDataprovider
    {
        BlogEntry Get(int id);
        BlogEntry Get(string slug);
        List<BlogEntry> List();
        List<BlogEntry> ListPublished();
        void Save(BlogEntry item);

        void SavePicture(blogpicture picture);
        blogpicture GetPicture(string filename);
        blogpicture GetPicture(string path,string filename);
        blogpicture GetPicture(int id);
        List<blogpicture> GetPictures();
    }
}