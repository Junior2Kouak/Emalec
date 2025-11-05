using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace MozartLib
{
  public static class CCertifiedPDF
  {
    private static string mCRTFile = @"emalec.com.pfx";
    private static string mPFXPwd = @"bmanpj";

    public static X509Certificate2 getCertificate2()
    {
      return new X509Certificate2(Path.Combine(MozartParams.CheminMozart, mCRTFile), mPFXPwd, (X509KeyStorageFlags) 32); // EphemeralKeySet constant ......
    }
  }
}
