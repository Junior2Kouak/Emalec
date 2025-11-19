////////////////////////////////////////////////////////////////////////
//  PROJECT :   Emalec Mobile PictureDirect         
//  --------															                              
//																		                                  
//  MODULE  :   PictureDirect.Models   
//  --------															                              
//																		                                  
//  FILE    :	  EActionModel.cs                     	
//  --------															                              
//																		                                  
//  DESCRIPTION :                                   					          
//  -----------	                                            			      
//	  Definition de la classe d'une Action (DataModel)
//																		                                  
//																		                                  
//  AUTHOR       DATE    VERSION     MODIFICATION						            
//  --------------------------------------------------------------------
//  APITECH  !25.09.18! V0.01    ! Creation of the file					        
//           !        !          !                  					          
////////////////////////////////////////////////////////////////////////

using PictureDirect.Models;
using PictureDirect.Services;
using PictureDirect.WCFService;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PictureDirect.Helpers
{
  public class SQLiteHelper
  {
    private SQLiteAsyncConnection _database;

    protected SQLiteHelper(string dbPath)
    {
      _database = new SQLiteAsyncConnection(dbPath);
      _database.CreateTableAsync<TPicture>().Wait();
      _database.CreateTableAsync<TConfig>().Wait();
    }

    private static SQLiteHelper _sqliteHelper;

    public static SQLiteHelper Instance
    {
      get
      {
        if (_sqliteHelper == null)
        {
            _sqliteHelper = new SQLiteHelper(DependencyService.Get<IGetDbPath>().GetDbPathString());
        }

        return _sqliteHelper;
      }
    }

    //public static SQLiteHelper SetPath(string dbPath)
    //{
    //  if (_sqliteHelper == null)
    //  {
    //    if (!string.IsNullOrEmpty(dbPath))
    //      _sqliteHelper = new SQLiteHelper(dbPath);
    //    else
    //      _sqliteHelper = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "PictureDirect.db3"));
    //  }
    //  return _sqliteHelper;
    //}

    public Task<List<TPicture>> GetPicturesAsync(int demandeId, int actionId)
    {
      return _database.QueryAsync<TPicture>($"SELECT * FROM [TPicture] WHERE [DemandeId] = {demandeId} AND [ActionId] = {actionId}");
    }

    public Task<List<TPicture>> GetPicturesNotInAsync(List<int> demandeIds)
    {
      if (demandeIds.Count > 0)
        return _database.QueryAsync<TPicture>($"SELECT * FROM [TPicture] WHERE [DemandeId] NOT IN ({string.Join(",", demandeIds)})");
      else
        return _database.QueryAsync<TPicture>($"SELECT * FROM [TPicture]");
    }

    public Task<List<TPicture>> GetPicturesNotDoneAsync()
    {
      return _database.QueryAsync<TPicture>("SELECT * FROM [TPicture] WHERE [Synced] = 0");
    }

    public Task<TPicture> GetPictureAsync(int id)
    {
      return _database.Table<TPicture>().Where(i => i.Id == id).FirstOrDefaultAsync();
    }

    public Task<int> SavePictureAsync(TPicture item)
    {
      if (item.Id != 0)
      {
        return _database.UpdateAsync(item);
      }
      else
      {
        return _database.InsertAsync(item);
      }
    }

    public Task<int> DeletePictureAsync(TPicture item)
    {
      return _database.DeleteAsync(item);
    }

    public Task<TConfig> GetConfigAsync()
    {
      return _database.Table<TConfig>().FirstOrDefaultAsync();
    }

    public Task<int> AddConfigAsync(TConfig item)
    {
      return _database.InsertAsync(item);
    }

    public Task<int> SaveConfigAsync(TConfig item)
    {
      return _database.UpdateAsync(item);
    }
  }
}
