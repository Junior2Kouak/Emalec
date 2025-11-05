using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Spreadsheet;


namespace MozartCS.Inventaire_Equipement
{
    class CInvEquipExportListFiches
    {

        public List<CExportFiche> Fiches { get; set; }
        public CInvEquipExportListFiches()
        {
            Fiches = new List<CExportFiche>();
        }
        public void AddFiche(string name, string code, string address, string phone)
        {
            var site = new CExportFiche(name, code, address, phone);
            Fiches.Add(site);
        }
        public void ClearFiches()
        {
            Fiches.Clear();
        }

    }
}

public class CExportFiche
{
    public string SiteName { get; set; }
    public string SiteCode { get; set; }
    public string SiteAddress { get; set; }
    public string SitePhone { get; set; }
    public CExportFiche(string name, string code, string address, string phone)
    {
        SiteName = name;
        SiteCode = code;
        SiteAddress = address;
        SitePhone = phone;
    }
}