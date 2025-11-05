using System;

namespace MozartCS.ListeClients
{
  class DevisStatusEventArgs : EventArgs
  {
    private String mStatutValidation;

    public String StatutValidation
    {
      get { return mStatutValidation; }
      set { mStatutValidation = value; }
    }
  }
}
