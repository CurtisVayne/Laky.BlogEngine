using Dapper;
using Laky.Blogengine.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Laky.Blogengine.Dataproviders
{
    public class BlogDataprovider : IBlogDataprovider
    {
        private string _cstr;

        public BlogDataprovider(string cstr)
        {
            _cstr = cstr;
        }

        public List<BlogEntry> List()
        {
            using (SqlConnection cn = new SqlConnection(_cstr))
            {
                return cn.GetList<BlogEntry>().OrderByDescending(p => p.created).ToList();
            }
        }

        public BlogEntry Get(int id)
        {
            using (SqlConnection cn = new SqlConnection(_cstr))
            {
                return cn.Get<BlogEntry>(id);
            }
        }

        public BlogEntry Get(string slug)
        {
            using (SqlConnection cn = new SqlConnection(_cstr))
            {
                return cn.QueryFirstOrDefault<BlogEntry>("select * from blogentry where slug='" + slug + "'");
            }
        }

        public void Save(BlogEntry item)
        {
            using (SqlConnection cn = new SqlConnection(_cstr))
            {
                if (item.blogid == 0)
                {
                    cn.Insert(item);
                }
                else
                {
                    cn.Update(item);
                }
            }
        }

        public List<BlogEntry> ListPublished()
        {
            using (SqlConnection cn = new SqlConnection(_cstr))
            {
                var now = DateTime.UtcNow;
                return cn.GetList<BlogEntry>().Where(p => p.published && p.created < now).OrderByDescending(p => p.created).ToList();
            }
        }

        public void SavePicture(blogpicture picture)
        {
            using (SqlConnection cn = new SqlConnection(_cstr))
            {
                cn.Insert<blogpicture>(picture);
            }
        }


        public blogpicture GetPicture(string filename)
        {
            using (SqlConnection cn = new SqlConnection(_cstr))
            {
                return cn.QueryFirstOrDefault<blogpicture>("select * from blogpicture where filename='" + filename + "'");
            }
        }

        public blogpicture GetPicture(string path, string filename)
        {
            using (SqlConnection cn = new SqlConnection(_cstr))
            {
                return cn.QueryFirstOrDefault<blogpicture>("select * from blogpicture where filename='" + filename + "' and path='" + path + "'");
            }

        }

        public blogpicture GetPicture(int id)
        {
            throw new NotImplementedException();
        }

        public List<blogpicture> GetPictures()
        {
            using (SqlConnection cn = new SqlConnection(_cstr))
            {
                return cn.GetList<blogpicture>().ToList();
            }
        }
    }
}
