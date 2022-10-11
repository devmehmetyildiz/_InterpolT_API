using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarNoteWebAPICore.Models
{
    public class CompanyModel
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }

        }

        private string companyname;
        public string Companyname
        {
            get { return companyname; }
            set { companyname = value; }
        }


        private string companyadress;
        public string Companyadress
        {
            get { return companyadress; }
            set { companyadress = value; }
        }


        private string taxno;
        public string Taxno
        {
            get { return taxno; }
            set { taxno = value; }
        }

        private string taxname;
        public string Taxname
        {
            get { return taxname; }
            set { taxname = value; }
        }

        private string isim;
        public string İsim
        {
            get { return isim; }
            set { isim = value; }
        }

        private string tckimlik;
        public string Tckimlik
        {
            get { return tckimlik; }
            set { tckimlik = value; }
        }

        private string telefon;
        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }


        private string eposta;
        public string Eposta
        {
            get { return eposta; }
            set { eposta = value; }
        }

        private string şehir;
        public string Şehir
        {
            get { return şehir; }
            set { şehir = value; }
        }

        private string ilçe;
        public string İlçe
        {
            get { return ilçe; }
            set { ilçe = value; }
        }

    }
}