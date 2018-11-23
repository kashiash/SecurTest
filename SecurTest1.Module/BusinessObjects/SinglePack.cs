using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabos.XPO.NVMS
{

    [DefaultClassOptions]
    [XafDefaultProperty(nameof(ProductDescription))]
    [NavigationItem("NVMS")]
    [XafDisplayName("SinglePack")]
    public class SinglePack : XPObject
    {
        public SinglePack(Session session) : base(session)
        { }


        //Test Pack IDs	

        string productName;
        string extendedData;
        string wholeSalername;
        string mahName;
        string mahID;
        string nHRN;
        string response;
        string nmvsFullResponse;
        DateTime createDate;
        string packStateReasons;
        string packState;
        string serialNumber;
        DateTime expiryDate;

        string batchID;
        string productCode;
        string scheme;
        string productDescription;
        string caseID;
        string packID;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string PackID
        {
            get => packID;
            set => SetPropertyValue(nameof(PackID), ref packID, value);
        }
        //Test Case Id	

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string CaseID
        {
            get => caseID;
            set => SetPropertyValue(nameof(CaseID), ref caseID, value);
        }
        //Product description	

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ProductDescription
        {
            get => productDescription;
            set => SetPropertyValue(nameof(ProductDescription), ref productDescription, value);
        }
        //Scheme	

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Scheme
        {
            get => scheme;
            set => SetPropertyValue(nameof(Scheme), ref scheme, value);
        }
        //Productcode	

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ProductCode
        {
            get => productCode;
            set => SetPropertyValue(nameof(ProductCode), ref productCode, value);
        }

        
        [Size(255)]
        public string ProductName
        {
            get => productName;
            set => SetPropertyValue(nameof(ProductName), ref productName, value);
        }

        //Batch-identification	

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string BatchID
        {
            get => batchID;
            set => SetPropertyValue(nameof(BatchID), ref batchID, value);
        }
        //Expiry date	


        public DateTime ExpiryDate
        {
            get => expiryDate;
            set => SetPropertyValue(nameof(ExpiryDate), ref expiryDate, value);
        }
        //Serialnumber	

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string SerialNumber
        {
            get => serialNumber;
            set => SetPropertyValue(nameof(SerialNumber), ref serialNumber, value);
        }
        //Packstate	

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string PackState
        {
            get => packState;
            set => SetPropertyValue(nameof(PackState), ref packState, value);
        }
        //Packstate reasons	

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string PackStateReasons
        {
            get => packStateReasons;
            set => SetPropertyValue(nameof(PackStateReasons), ref packStateReasons, value);
        }

        public DateTime CreateDate
        {
            get => createDate;
            set => SetPropertyValue(nameof(CreateDate), ref createDate, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string NmvsFullResponse
        {
            get => nmvsFullResponse;
            set => SetPropertyValue(nameof(NmvsFullResponse), ref nmvsFullResponse, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Response
        {
            get => response;
            set => SetPropertyValue(nameof(Response), ref response, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string NHRN
        {
            get => nHRN;
            set => SetPropertyValue(nameof(NHRN), ref nHRN, value);
        }

        [Size(255)]
        public string MahID
        {
            get => mahID;
            set => SetPropertyValue(nameof(MahID), ref mahID, value);
        }

        [Size(255)]
        public string MahName
        {
            get => mahName;
            set => SetPropertyValue(nameof(MahName), ref mahName, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string WholeSalername
        {
            get => wholeSalername;
            set => SetPropertyValue(nameof(WholeSalername), ref wholeSalername, value);
        }
        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ExtendedData
        {
            get => extendedData;
            set => SetPropertyValue(nameof(ExtendedData), ref extendedData, value);
        }
    }
}
