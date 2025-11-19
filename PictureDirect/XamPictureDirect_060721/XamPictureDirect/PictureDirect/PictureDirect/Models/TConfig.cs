using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PictureDirect.Models
{
  public class TConfig
  {
    [PrimaryKey]
    [AutoIncrement]
    public int Id { get; set; }

    public string EndpointAddress { get; set; }

    public int DefaultNumUser { get; set; }

    public string DefaultLogin { get; set; }

    public string DefaultPassword { get; set; }

    public int CompressionQuality { get; set; }

    public int PhotoSize { get; set; }

    public int MaxNumberOfPictures { get; set; }
  }
}
