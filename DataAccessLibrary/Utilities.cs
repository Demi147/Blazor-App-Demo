using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Linq;
using System.Net.Mail;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.IO;

namespace DataAccessLibrary
{
    enum Atributes
    {
        test
    }
    public enum BooksAtributes
    {
        BookTitle,
        BookEdition,
        BookPrice,
        ModuleCode,
        BooksInstitute,
        LocationID
    }

    public static class Utilities
    {
        private static string IV = "1q8myj6c9s23rgvq"; //16 chars
        private static string key = "b365ghyxa741258dfpol934ecvrg70qs"; //32 chars

        private static string Message { get; set; } = "";

        //Check if generic list contains an item
        //public static bool CheckIfContains<T>(List<T> _list,T _item) where T:TestInterface
        //{
        //    foreach (var item in _list)
        //    {
        //        if (item.isEqualTo(_item))
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}
        public static string ExcryptPassword(string _input)
        {
            Byte[] textbytes = ASCIIEncoding.ASCII.GetBytes(_input);

            using (AesCryptoServiceProvider endec = new AesCryptoServiceProvider())
            {
                endec.BlockSize = 128;
                endec.KeySize = 256;
                endec.Key = ASCIIEncoding.ASCII.GetBytes(key);
                endec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
                endec.Padding = PaddingMode.PKCS7;
                endec.Mode = CipherMode.CBC;

                var incrypt = endec.CreateEncryptor(endec.Key, endec.IV);

                byte[] enc = incrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
                incrypt.Dispose();

                return Convert.ToBase64String(enc);
            }
        }
        public static string DecryptPassword(string _input)
        {
            Byte[] textbytes = Convert.FromBase64String(_input);

            using (AesCryptoServiceProvider endec = new AesCryptoServiceProvider())
            {
                endec.BlockSize = 128;
                endec.KeySize = 256;
                endec.Key = ASCIIEncoding.ASCII.GetBytes(key);
                endec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
                endec.Padding = PaddingMode.PKCS7;
                endec.Mode = CipherMode.CBC;

                var decrypt = endec.CreateDecryptor(endec.Key, endec.IV);

                byte[] enc = decrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
                decrypt.Dispose();

                return ASCIIEncoding.ASCII.GetString(enc);
            }
        }

        public static List<T> Page<T>(this List<T> en, int pageSize, int page)
        {
            return en.Skip(page * pageSize).Take(pageSize).ToList();
        }


        public static void SendMail()
        {


            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("sys.paradigm@gmail.com");//sys.paradigm@gmail.com Sp2020sP
                    mail.To.Add("francobester17@gmail.com");
                    mail.Subject = "Sending Mail Testing (Blazor)";
                    mail.Body = "<h1> Testing mail from blazor app</h1>";
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential("sys.paradigm@gmail.com", "Sp2020sP");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);

                        Message = "Mail sent";
                    }
                }
            }
            catch (Exception ex)
            {
                Message = ex.ToString();
            }
        }

        public static void SendMail(string _to, string _subject, string _body, bool _isbodyHtml)
        {


            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("sys.paradigm@gmail.com");//sys.paradigm@gmail.com Sp2020sP
                    mail.To.Add(_to);
                    mail.Subject = _subject;
                    mail.Body = _body;
                    mail.IsBodyHtml = _isbodyHtml;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential("sys.paradigm@gmail.com", "Sp2020sP");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);

                        Message = "Mail sent";
                    }
                }
            }
            catch (Exception ex)
            {
                Message = ex.ToString();
            }
        }

        public static string GenerateRegisterMessage(string _name, string _email, string _password)
        {
            string message = string.Format(
                "<h1>Welcome {0}</h1><br><br>" +
                "You have registeredededed to our service with the following info.<br>" +
                "Email {1} <br>" +
                "Password {2}"

                , _name, _email, _password);
            return message;
        }

        public static string GenerateDeRegisterMessage(string _name, string _email)
        {
            string message = string.Format(
                "<h1>Hello {0}</h1><br><br>" +
                "You have deregisteredededed to our service and deleted the following account.<br>" +
                "Email {1} <br>"

                , _name, _email);
            return message;
        }

        public static byte[] CreatePDF(string _body)
        {
            PdfDocument document = new PdfDocument();

            PdfPage page = document.Pages.Add();

            PdfGraphics graphics = page.Graphics;

            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 12);

            graphics.DrawString(_body, font, PdfBrushes.Black, new Syncfusion.Drawing.PointF(0, 0));

            MemoryStream pdfstream = new MemoryStream();

            document.Save(pdfstream);
            document.Close(true);

            return pdfstream.ToArray();
        }
    }

}
