using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        void ContentAddBl(Content content);
        Content GetById(int id);
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
        List<Content> GetListByHeadingId(int id);
        List<Content> GetListByWriter(int id);
    }
}
