using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PictureDirect.Services
{
  public interface IDeleteFile
  {
    void Delete(string path);
  }
}
