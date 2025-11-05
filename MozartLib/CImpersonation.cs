using Microsoft.Win32.SafeHandles;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading.Tasks;

namespace MozartLib
{
  // Classe de gestion de l'impersonation

  [CLSCompliant(true)]
  public class CImpersonation
  {
    [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
    private static extern bool LogonUser(String lpszUsername, String lpszDomain, String lpszPassword, int dwLogonType, int dwLogonProvider, out SafeAccessTokenHandle phToken);

    // Variables spécifiques pour l'impersonation
    private static string mUserName = "mozart";
    private static string mDomainName = "emalec.com";
    private static string mUserPwd = "";

    private const int mLOGON32_LOGON_NEW_CREDENTIALS = 9;
    private const int mLOGON32_PROVIDER_WINNT50 = 3;

    public static string OpenFileImpersonated(string strFile)
    {
      string msg = "";

      getUserPassword();

      SafeAccessTokenHandle safeAccessTokenHandle;
      bool returnValue = LogonUser(mUserName, mDomainName, mUserPwd, mLOGON32_LOGON_NEW_CREDENTIALS, mLOGON32_PROVIDER_WINNT50, out safeAccessTokenHandle);

      if (false == returnValue)
      {
        int ret = Marshal.GetLastWin32Error();
        msg += $"{Environment.NewLine}LogonUser failed with error code : {ret}";
      }

      string sTempFile = $@"{Path.GetTempFileName()}";
      WindowsIdentity.RunImpersonated(safeAccessTokenHandle, () =>
      {
        File.Copy(strFile, sTempFile, true);
      });
      string sNewTempFile = $"{sTempFile}.Mozart{Path.GetExtension(strFile)}";
      File.Move(sTempFile, sNewTempFile);

      return sNewTempFile;
    }

    public static void DeleteFileImpersonated(string strFile)
    {
      string msg = "";

      getUserPassword();

      SafeAccessTokenHandle safeAccessTokenHandle;
      bool returnValue = LogonUser(mUserName, mDomainName, mUserPwd, mLOGON32_LOGON_NEW_CREDENTIALS, mLOGON32_PROVIDER_WINNT50, out safeAccessTokenHandle);

      if (false == returnValue)
      {
        int ret = Marshal.GetLastWin32Error();
        msg += $"\r\nLogonUser failed with error code : {ret}";
      }

      WindowsIdentity.RunImpersonated(safeAccessTokenHandle, () =>
      {
        File.Delete(strFile);
      });
    }

    public static void MoveFileImpersonated(string strFileSource, string strFileDest)
    {
      string msg = "";

      getUserPassword();

      SafeAccessTokenHandle safeAccessTokenHandle;
      bool returnValue = LogonUser(mUserName, mDomainName, mUserPwd, mLOGON32_LOGON_NEW_CREDENTIALS, mLOGON32_PROVIDER_WINNT50, out safeAccessTokenHandle);

      if (false == returnValue)
      {
        int ret = Marshal.GetLastWin32Error();
        msg += $"\r\nLogonUser failed with error code : {ret}";
      }

      WindowsIdentity.RunImpersonated(safeAccessTokenHandle, () =>
      {
        File.Move(strFileSource, strFileDest);
      });
    }

    public static void CopyFileImpersonated(string strFileSrc, string strFileDest, string strPassword, bool bOverWrite)
    {
      string msg = "";

      if (strPassword == "")
      {
        getUserPassword();
      } else
      {
        mUserPwd = strPassword;
      }

      SafeAccessTokenHandle safeAccessTokenHandle;
      bool returnValue = LogonUser(mUserName, mDomainName, mUserPwd, mLOGON32_LOGON_NEW_CREDENTIALS, mLOGON32_PROVIDER_WINNT50, out safeAccessTokenHandle);

      if (false == returnValue)
      {
        int ret = Marshal.GetLastWin32Error();
        msg += $"\r\nLogonUser failed with error code : {ret}";
      }

      try
      {
        WindowsIdentity.RunImpersonated(safeAccessTokenHandle, () =>
        {
          File.Copy(strFileSrc, strFileDest, bOverWrite);
        });
      }
      catch (Exception ex)
      {
        if (ex.Message.Contains("est refusé"))
        {
          throw new Exception("Problème de droit d'accès : copier le fichier en local avant de l'insérer dans Mozart. Merci");
        }
        else
          throw ex;
      }
    }

    // Copie en écrasant le fichier destination
    public static void CopyFileImpersonated(string strFileSrc, string strFileDest)
    {
      CopyFileImpersonated(strFileSrc, strFileDest, "", true);
    }

    // Copie avec passage du mot de passe pour le web report
    public static void CopyFileImpersonated(string strFileSrc, string strFileDest, string strPwd)
    {
      CopyFileImpersonated(strFileSrc, strFileDest, strPwd, true);
    }

    public static bool FileExistImpersonated(string strFile)
    {
      string msg = "";
      bool Test = false;

      getUserPassword();

      SafeAccessTokenHandle safeAccessTokenHandle;
      bool returnValue = LogonUser(mUserName, mDomainName, mUserPwd, mLOGON32_LOGON_NEW_CREDENTIALS, mLOGON32_PROVIDER_WINNT50, out safeAccessTokenHandle);

      if (false == returnValue)
      {
        int ret = Marshal.GetLastWin32Error();
        msg += $"\r\nLogonUser failed with error code : {ret}";
      }
      else
      {
        WindowsIdentity.RunImpersonated(safeAccessTokenHandle, () =>
        {
          Test = File.Exists(strFile);
        });
      }
      return Test;
    }

    public static void DeleteTemporaryFile()
    {
      var fileNames = Directory.GetFiles(Path.GetTempPath(), "*.Mozart.*");
      foreach (string f in fileNames)
      {
        Task.Run(() => File.Delete(f));
      }
    }

    private static void getUserPassword()
    {
      if (mUserPwd == "")
        mUserPwd = MozartDatabase.ExecuteScalarString("SELECT CONVERT(VARCHAR(30), DecryptByPassPhrase(VCOMMENT, VPARVAL)) FROM TPAR WHERE VPARLIB = 'USER_IMPERSONATION'");
    }
  }
}
