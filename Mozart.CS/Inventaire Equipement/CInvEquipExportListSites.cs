using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MozartCS.Inventaire_Equipement
{
    class CInvEquipExportListSites
    {

        public List<CExportSite> Sites { get; set; }
        public CInvEquipExportListSites()
        {
            Sites = new List<CExportSite>();
        }
        public void AddSite(string name, string code, string address, string phone)
        {
            var site = new CExportSite(name, code, address, phone);
            Sites.Add(site);
        }
        public void ClearSites()
        {
            Sites.Clear();
        }

    }
}

public class CExportSite
{
    public string SiteName { get; set; }
    public string SiteCode { get; set; }
    public string SiteAddress { get; set; }
    public string SitePhone { get; set; }
    public CExportSite(string name, string code, string address, string phone)
    {
        SiteName = name;
        SiteCode = code;
        SiteAddress = address;
        SitePhone = phone;
    }
}