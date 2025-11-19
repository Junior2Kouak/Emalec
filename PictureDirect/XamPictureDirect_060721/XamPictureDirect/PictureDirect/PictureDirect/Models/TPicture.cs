using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PictureDirect.Models
{
  public class TPicture
  {
    [PrimaryKey]
    [AutoIncrement]
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int DemandeId { get; set; }

    public int ActionId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Path { get; set; }

    public bool Synced { get; set; }

    public bool Error { get; set; }
  }
}
