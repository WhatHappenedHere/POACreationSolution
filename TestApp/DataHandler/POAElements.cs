using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.DataHandler
{
    public class POAElements
    {
        public DateTime dateOfIssue { get; private set; }
        public DateTime expirationDate { get; private set; }
        public DateTime documentDate { get; private set; }
        public int documentNumber { get; private set; }
        public int personsDocumentNumber { get; private set; }
        public String recipient { get; private set; }
        public String payer { get; private set; }
        public String issuedToPerson { get; private set; }
        public String documentType { get; private set; }
        public String series { get; private set; }
        public String personsDocumentDate { get; private set; }
        public String personsDocumentIssuedOrganization { get; private set; }
        public String provider { get; private set; }
        public String order { get; private set; }        

        public POAElements(string tempData)
        {
            string[] parts = tempData.Split('☼');
            dateOfIssue = DateTime.Parse(parts[0]);
            expirationDate = DateTime.Parse(parts[1]);
            documentNumber = int.Parse(parts[2]);
            documentDate = DateTime.Parse(parts[3]);
            recipient = parts[4];
            payer = parts[5];
            issuedToPerson = parts[6];
            documentType = parts[7];
            series = parts[8];
            personsDocumentNumber = int.Parse(parts[9]);
            personsDocumentDate = parts[10];
            personsDocumentIssuedOrganization = parts[11];
            provider = parts[12];
            order = parts[13];
        }

}
}
