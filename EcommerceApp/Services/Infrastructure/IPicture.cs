using EcommerceApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.Services.Infrastructure
{
    public interface IPicture
    {
        Picture GetById(int pictureId);

        void Insert(Picture picture);

        void Update(Picture picture);

        void Delete(int pictureId);

        void Save();
    }
}
