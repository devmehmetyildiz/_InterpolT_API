using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StarNoteWebAPICore.Models
{
    public class ReportsettingModel
    {
   private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string concurrencyStamp;
        public string ConcurrencyStamp
        {
            get { return concurrencyStamp; }
            set { concurrencyStamp = value; }
        }

        private string reportname;
        public string Reportname
        {
            get { return reportname; }
            set { reportname = value; }
        }

        private int reportid;
        public int Reportid
        {
            get { return reportid; }
            set { reportid = value; }
        }

        private int reporttype;
        public int Reporttype
        {
            get { return reporttype; }
            set { reporttype = value; }
        }

        private string reporttypename;
        public string Reporttypename
        {
            get { return reporttypename; }
            set { reporttypename = value; }
        }

        private bool isActive;
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        private DateTime? lastsendtime;
        public DateTime? Lastsendtime
        {
            get { return lastsendtime; }
            set { lastsendtime = value; }
        }

        private DateTime? createtime;
        public DateTime? Createtime
        {
            get { return createtime; }
            set { createtime = value; }
        }

        private DateTime? updatetime;
        public DateTime? Updatetime
        {
            get { return updatetime; }
            set { updatetime = value; }
        }

        private DateTime? deletetime;

        public DateTime? Deletetime
        {
            get { return deletetime; }
            set { deletetime = value; }
        }

        private string createdUser;
        public string CreatedUser
        {
            get { return createdUser; }
            set { createdUser = value; }
        }

        private string updatedUser;

        public string UpdatedUser
        {
            get { return updatedUser; }
            set { updatedUser = value; }
        }

        private string deleteUser;

        public string DeleteUser
        {
            get { return deleteUser; }
            set { deleteUser = value; }
        }

        private string mailusers;
        public string Mailusers
        {
            get { return mailusers; }
            set { mailusers = value; }
        }

    }
}
