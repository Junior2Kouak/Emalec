using DevExpress.CodeParser;
using DevExpress.Pdf;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmMenuInformatique : Form
  {
    public frmMenuInformatique()
    {
      InitializeComponent();
    }

    private void frmMenuInformatique_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

				Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdLogWeb_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeLogweb().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdMenu_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmStatMenuWebClient().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdCnx_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmStatWebClient().ShowDialog();
      Cursor.Current = Cursors.Default;
    }


    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdGLPI_Click(object sender, EventArgs e)
    {
      if ((MozartParams.strUID == "GIRAUD-BY") || (MozartParams.strUID == "SAUVAGEON"))
      {
        Cursor.Current = Cursors.WaitCursor;
        new frmListeVisites().ShowDialog();
        Cursor.Current = Cursors.Default;
      }
    }


    private void apiButton2_Click(object sender, EventArgs e)
    {

      //MozartUC.Utils.MakePhoneCallAVAYA("0680937093");

      // Generate a 128-bit salt using a sequence of
      // cryptographically strong random bytes.
      const int SaltSize = 128 / 8; // 128 bits
      const int Pbkdf2SubkeyLength = 256 / 8; // 256 bits
      byte[] salt = new byte[SaltSize];
      RNGCryptoServiceProvider png = new RNGCryptoServiceProvider();
      png.GetNonZeroBytes(salt); // divide by 8 to convert bits to bytes


      Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes("IRIS2019", salt, 1000);
      byte[] lRet = rfc2898DeriveBytes.GetBytes(Pbkdf2SubkeyLength);
      var outputBytes = new byte[1 + SaltSize + Pbkdf2SubkeyLength];
      outputBytes[0] = 0x00; // format marker
      Buffer.BlockCopy(salt, 0, outputBytes, 1, SaltSize);
      Buffer.BlockCopy(lRet, 0, outputBytes, 1 + SaltSize, Pbkdf2SubkeyLength);

      string lRetStr = Convert.ToBase64String(outputBytes);

    }

    private void apiButton1_Click(object sender, EventArgs e)
    {

      Main4();

      //PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor();

      //documentProcessor.LoadDocument(@"..\..\rptPPSM.pdf");

      ////Provide a signature certificate:
      //X509Certificate2 certificate = new X509Certificate2(@"..\..\SignDemo.pfx", "dxdemo");  // certificat + mot de passe

      //// recherche du numéro IDPPS
      //PdfFormData formData = documentProcessor.GetFormData();
      //Console.WriteLine(formData["IDPPS_0"].Value);

      //// recherche du Chaff et pose de sa signature

      //byte[] imageData = File.ReadAllBytes("..\\..\\Signature1837.png");
      //int pageNumber = documentProcessor.Document.Pages.Count;



      //int angleInDegrees = 0;
      //double angleInRadians = angleInDegrees * (Math.PI / 180);
      //PdfOrientedRectangle signatureBounds = new PdfOrientedRectangle(new PdfPoint(620, 210), 250, 90, angleInRadians);
      //PdfSignature signature = new PdfSignature(certificate, imageData, pageNumber, signatureBounds);

      //signature.Location = "FRANCE";
      //signature.ContactInfo = "facturation@emalec.com.com";
      //signature.Reason = "Signature digitale";

      //documentProcessor.SaveDocument(@"..\..\PPSSigned.pdf", new PdfSaveOptions() { Signature = signature });

      //Process.Start(@"..\..\PPSSigned.pdf");

    }

    static void Main4()
    {
      
      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TWORD",
        sIdentifiant = @"C:\Users\GALOTTI\Documents\ASPIRANT.doc", //1497.pdf",
        InfosMail = $"TCLI|NCLINUM|255",
        sNomSociete = MozartParams.NomSociete,
        sLangue = "FR",
        sOption = "PREVIEW"
      }.ShowDialog();

    }

    static void Main5()
    {

      PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor();

      // chargement du fichier pdf
      documentProcessor.LoadDocument(@"C:\Users\GALOTTI\Documents\1497.pdf");

      PdfFormData formData = documentProcessor.GetFormData();

      System.Collections.Generic.IList<string> names = formData.GetFieldNames();

      MessageBox.Show($"Format du document {formData["IDTYPE_0"].Value}{Environment.NewLine}ID {formData["IDPPS_0"].Value}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

      documentProcessor.CloseDocument();

    }

    static void Main6()
    {
      PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor();

      // chargement du fichier pdf
      documentProcessor.LoadDocument(@"c:\temp\rptPPSM.pdf");

      using (PdfGraphics graph = documentProcessor.CreateGraphics())
      {

        // recherche de la signature du Chaff dans la base 
        //Image img = Image.FromFile("c:\\temp\\1837.png");
        //byte[] imageData = File.ReadAllBytes("c:\\temp\\1837.png");

        //byte[] imageData = (byte[])ModuleData.ExecuteScalarObject($"exec api_sp_GetSignaturePersonnel 3437 ");


        //*****************************************************************************************************************************
        // recherche de la position du libellé de référence pour poser la signature (en blanc sur fond blanc dans le document) 
        PdfTextSearchResults result;

        result = documentProcessor.FindText("Code--Case--Signature--Chaff");

        //************************************************************************************************

        // repérage avec hilight pour les tests
        //using (var brush = new SolidBrush(Color.FromArgb(130, 55, 155, 255)))
        //graph.FillRectangle(brush, rect1);

        // Ajout du nom du valideur
        string Nom = "GALOTTI Frédéric";
        string Validation = "Je valide ce document";
        string text = $"le {DateTime.Now.ToShortDateString()}";

        using (SolidBrush textBrush = new SolidBrush(Color.FromArgb(255, Color.DarkBlue)))
        {
          using (Font font = new Font("Segoe UI", 11, FontStyle.Regular))
          {
            // calcul de la position en fonction de la position du libellé de référence
            PointF textPoint = new PointF((float)result.Rectangles[0].Left, (float)result.Page.CropBox.Height - (float)result.Rectangles[0].Top - 20);
            PointF textPoint2 = new PointF((float)result.Rectangles[0].Left, (float)result.Page.CropBox.Height - (float)result.Rectangles[0].Top + 5);
            PointF textPoint3 = new PointF((float)result.Rectangles[0].Left, (float)result.Page.CropBox.Height - (float)result.Rectangles[0].Top + 40);

            // ajout date dans le document
            graph.DrawString(Nom, font, textBrush, textPoint);
            graph.DrawString(Validation, font, textBrush, textPoint2);
            graph.DrawString(text, font, textBrush, textPoint3);
            graph.AddToPageForeground(result.Page, 72, 72);
          }
        }

        //**********************************************************************************

        // définition du rectangle de dépose de la signature du Chaff
        RectangleF rect =
            new RectangleF(new PointF((float)result.Rectangles[0].Left, (float)result.Page.CropBox.Height - (float)result.Rectangles[0].Top),
            new SizeF((float)result.Rectangles[0].Width + 16, (float)result.Rectangles[0].Height + 37));

        // repérage avec hilight pour les tests
        //using (var brush = new SolidBrush(Color.FromArgb(130, 55, 155, 255)))
        //graph.FillRectangle(brush, rect);

        // pose de la signature sur le document dans le rectangle
        //graph.DrawImage(imageData, rect);
        //graph.AddToPageForeground(result.Page, 72, 72);


        //*******************************************************************************
        RectangleF rect1 =
           new RectangleF(new PointF((float)result.Rectangles[0].Left + 115, (float)result.Page.CropBox.Height - (float)result.Rectangles[0].Top + 7),
           new SizeF(13, 13));

        var checkBox = new PdfGraphicsAcroFormCheckBoxField("boxchaff", rect1);

        // Specify text and appearance parameters.
        checkBox.IsChecked = true;
        checkBox.ButtonStyle = PdfAcroFormButtonStyle.Check;
        checkBox.Appearance.FontSize = 2;
        checkBox.Appearance.BackgroundColor = Color.Silver;

        graph.AddFormField(checkBox);

        graph.AddToPageForeground(result.Page, 72, 72);

        // des&ctivation des form Field
        documentProcessor.FlattenForm();

        // enregistrement du document
        documentProcessor.SaveDocument(@"c:\temp\SignedPPSM.pdf");

        Process.Start(@"c:\temp\SignedPPSM.pdf");



      }
    }

		private void apiButton3_Click(object sender, EventArgs e)
		{
      frameFiliale.Visible = true;
      txtAction.Text = txtDI.Text = "";
    }

    private void cmdCopieFiliale6_Click(object sender, EventArgs e)
		{
      frameFiliale.Visible = false;
      txtAction.Text = txtDI.Text = "";
    }

    private void cmdCopieFiliale0_Click(object sender, EventArgs e)
		{
      int compteur = 0;
      int compteurAbs = 0;
      int Action = txtAction.Text == "" ? 0 : Convert.ToInt32(txtAction.Text);

      // répertoire de destination des fichiers
      string Dest = $"C:\\Temp\\DI{txtDI.Text}\\";

      string Sql = $"select  NIMAGE, " +
        $"case VTYPE when 'ATTACH' then 'E:\\DocsWeb02\\EMALEC\\AttGamPdf\\' + TIMAC.VFICHIER " +
        $" when 'GAMME'  then 'E:\\DocsWeb02\\EMALEC\\AttGamPdf\\' + TIMAC.VFICHIER " +
        $" when 'ATTEST' then 'E:\\DocsWeb02\\EMALEC\\AttGamPdf\\' + TIMAC.VFICHIER " +
        $" when 'IMAGE'  then 'E:\\DocsWeb02\\EMALEC\\PhotosAct\\' + TIMAC.VFICHIER " +
        $" when 'PJ'     then 'E:\\DocsWeb02\\EMALEC\\PhotosAct\\' + TIMAC.VFICHIER " +
        $" when 'PJW'    then 'E:\\DocsWeb02\\EMALEC\\PhotosAct\\' + TIMAC.VFICHIER " +
        $" when 'DEVTEC' then 'E:\\DocsWeb02\\EMALEC\\PhotosAct\\' + TIMAC.VFICHIER " +
        $" when 'RAPTEC' then 'E:\\DocsWeb02\\EMALEC\\PhotosAct\\' + TIMAC.VFICHIER " +
        $" end as VFICHIER, " +
        $" VTYPE , ntypedoc, a.NDINNUM, " +
        $" Cast(a.NDINNUM as varchar) + '_' + Cast(NACTID as varchar) + '_' + Cast(NIMAGE as varchar) + '.' + cformat 'FILE' " +
        $" from TIMAC inner join tact a on TIMAC.nactnum = a.nactnum inner join tsit s on s.nsitnum = a.nsitnum " +
        $" inner join tdin d on d.ndinnum = a.ndinnum inner join tcli c on d.nclinum = c.nclinum " +
        $" where vsociete = 'EMALEC' and a.NDINNUM = {txtDI.Text}" +
        $" and (a.NACTID = {txtAction.Text} or {Action} = 0)";


      using (SqlDataReader sdrDev = ModuleData.ExecuteReader(Sql))
      {
        if (!Directory.Exists(Dest)) {Directory.CreateDirectory(Dest);}

        while (sdrDev.Read())
        {
          if (File.Exists(sdrDev["VFICHIER"].ToString()))
          {
            File.Copy(sdrDev["VFICHIER"].ToString(), Dest + Path.GetFileName(sdrDev["VFICHIER"].ToString()), true);
            compteur = compteur + 1;
          }
          else
          {
            compteurAbs = compteurAbs + 1;
          }
        }

        MessageBox.Show($"Fichiers copiés : {compteur}{Environment.NewLine}Fichiers absents : {compteurAbs}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

        txtAction.Text = txtDI.Text = "";
        frameFiliale.Visible = false;
      }
    }

		private void apiButton4_Click(object sender, EventArgs e)
		{
      new frmDetailMsgOutlook("",0).ShowDialog();

    }
	}
}

