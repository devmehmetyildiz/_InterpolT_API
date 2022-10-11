using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StarNoteWebAPICore.Models
{
    public class OrderModel
    {
        private CostumerOrderModel costumerorder;
        public CostumerOrderModel Costumerorder
        {
            get { return costumerorder; }
            set { costumerorder = value; }
        }

        private List<JobOrderModel> joborder;
        public List<JobOrderModel> Joborder
        {
            get { return joborder; }
            set { joborder = value; }
        }

        [NotMapped]
        public bool IsNewRecord { get; set; }
    }
}