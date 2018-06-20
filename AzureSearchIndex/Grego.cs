//using Microsoft.Azure.Search;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AzureSearchIndex
//{
//    public class Rootobject
//    {
//        public int page { get; set; }
//        public int total { get; set; }
//        public int records { get; set; }
//        //public Row[] rows { get; set; }
//    }

//    public class Row
//    {
//        [System.ComponentModel.DataAnnotations.Key]
//        [IsFilterable, IsSortable, IsFacetable]
//        public string id { get; set; }
//        [IsFilterable, IsSortable, IsFacetable]
//        public int versionValue { get; set; }
//        [IsFilterable, IsSortable, IsSearchable]
//        public string uuid { get; set; }
//        [IsFilterable, IsSortable, IsSearchable]
//        public string createdBy { get; set; }
//        [IsFilterable, IsSortable, IsSearchable]
//        public string createdDate { get; set; }
//        [IsFilterable, IsSortable, IsSearchable]
//        public string lastModifiedBy { get; set; }
//        public string lastModifiedDate { get; set; }
//        public int companyid { get; set; }
//        public string name { get; set; }
//        public string displayName { get; set; }
//        public string salutation { get; set; }
//        public string firstName { get; set; }
//        public string middleName { get; set; }
//        public string lastName { get; set; }
//        public string nickName { get; set; }
//        public string suffix { get; set; }
//        public int genderid { get; set; }
//        public string businessUnitid { get; set; }
//        public string dateOfBirth { get; set; }
//        public string[] contactTypes { get; set; }
//        public string accountingReference { get; set; }
//        public string referenceId { get; set; }
//        //public Languagemapping[] languageMappings { get; set; }
//        //public Primarynumber primaryNumber { get; set; }
//        //public Number[] numbers { get; set; }
//        //public Primaryaddress primaryAddress { get; set; }
//        public double? lat { get; set; }
//        public double? lng { get; set; }
//        //public Address[] addresses { get; set; }
//        //public Primaryemail primaryEmail { get; set; }
//        //public Email[] emails { get; set; }
//        public bool? hasTransportation { get; set; }
//        public bool? hasChildren { get; set; }
//        public string notes { get; set; }
//        public string companyName { get; set; }
//        public string website { get; set; }
//        public string region { get; set; }
//        public string countryOfOrigin { get; set; }
//        public string countryOfResidence { get; set; }
//        public string countryOfNationality { get; set; }
//        public string active { get; set; }
//        public string activeNote { get; set; }
//        public string availability { get; set; }
//        public string experience { get; set; }
//        public string registeredTaxId { get; set; }
//        public string bankAccount { get; set; }
//        public string sortCode { get; set; }
//        public string iban { get; set; }
//        public string swift { get; set; }
//        public string eftid { get; set; }
//        public string eftname { get; set; }
//        public string paymentMethodid { get; set; }
//        public string paymentMethodname { get; set; }
//        public bool registeredTax { get; set; }
//        public string registeredTaxIdDescription { get; set; }
//        public int employmentCategoryid { get; set; }
//        public string employmentCategorydescription { get; set; }
//        public int assignmentTierid { get; set; }
//        public string timeZone { get; set; }
//        public string ethnicity { get; set; }
//        public string document { get; set; }
//        public string imagePath { get; set; }
//        public bool outOfOffice { get; set; }
//        public string disableUpcomingReminder { get; set; }
//        public string disableCloseReminder { get; set; }
//        public string disableConfirmReminder { get; set; }
//        public string bankAccountDescription { get; set; }
//        public string timeWorked { get; set; }
//        public string activationDate { get; set; }
//        public string originalStartDate { get; set; }
//        public string datePhotoSentToPrinter { get; set; }
//        public string datePhotoSentToInterpreter { get; set; }
//        public string inductionDate { get; set; }
//        public string reActivationDate { get; set; }
//        public string iolNrcpdNumber { get; set; }
//        public string referralSource { get; set; }
//        public string refereeSourceName { get; set; }
//        public string recruiterName { get; set; }
//        public string taleoId { get; set; }
//        public string bankAccountReference { get; set; }
//        //public Status status { get; set; }
//        //public Ratesummary rateSummary { get; set; }
//        public string distance { get; set; }
//        public int? rating { get; set; }
//        public int? languagesId { get; set; }
//        public string language { get; set; }
//        public string languageCode { get; set; }
//        public string moreLanguages { get; set; }
//        public string employmentEligibilityStatus { get; set; }
//        public string number { get; set; }
//        public string address { get; set; }
//        public string email { get; set; }
//    }

//    public class Primarynumber
//    {
//        public int id { get; set; }
//        public string parsedNumber { get; set; }
//        public string numberFormatted { get; set; }
//        public string countryCode { get; set; }
//        public string areaCode { get; set; }
//        public string number { get; set; }
//        public int typeid { get; set; }
//        public bool primaryNumber { get; set; }
//    }

//    public class Primaryaddress
//    {
//        public int id { get; set; }
//        public string clientid { get; set; }
//        public string clientLabel { get; set; }
//        public int companyid { get; set; }
//        public string customerid { get; set; }
//        public string customerBillingid { get; set; }
//        public string displayLabel { get; set; }
//        public string description { get; set; }
//        public string notes { get; set; }
//        public string addrEntered { get; set; }
//        public string addrFormatted { get; set; }
//        public string aptUnit { get; set; }
//        public string preamble { get; set; }
//        public string street1 { get; set; }
//        public string street2 { get; set; }
//        public string street3 { get; set; }
//        public string cityTown { get; set; }
//        public string stateCounty { get; set; }
//        public string postalCode { get; set; }
//        public string country { get; set; }
//        public bool primaryAddress { get; set; }
//        public bool valid { get; set; }
//        public string validationStatus { get; set; }
//        public bool validated { get; set; }
//        public int typeid { get; set; }
//        public float lat { get; set; }
//        public float lng { get; set; }
//        public string addressPhone { get; set; }
//        public string addressFax { get; set; }
//        public string addressEmail { get; set; }
//        public string contactPerson { get; set; }
//        public string costCenter { get; set; }
//        public bool active { get; set; }
//        public string parentid { get; set; }
//        public string parentlabel { get; set; }
//        public string publicNotes { get; set; }
//        public string regionid { get; set; }
//        public string billingRegionid { get; set; }
//        public string costCenterName { get; set; }
//        public string timeZone { get; set; }
//    }

//    public class Primaryemail
//    {
//        public int id { get; set; }
//        public string emailAddress { get; set; }
//        public string addressVerified { get; set; }
//        public string dateVerified { get; set; }
//        public bool primaryEmail { get; set; }
//        public int typeid { get; set; }
//    }

//    public class Status
//    {
//        public string _class { get; set; }
//        public int id { get; set; }
//        public bool defaultOption { get; set; }
//        public string description { get; set; }
//        public string l10nKey { get; set; }
//        public string name { get; set; }
//        public string nameKey { get; set; }
//    }

//    public class Ratesummary
//    {
//        public string inperson { get; set; }
//        public string phone { get; set; }
//        public string video { get; set; }
//    }

//    public class Languagemapping
//    {
//        public int id { get; set; }
//        public int contactid { get; set; }
//        public int languageid { get; set; }
//        public Language language { get; set; }
//        public string rating { get; set; }
//    }

//    public class Language
//    {
//        public int id { get; set; }
//        public string label { get; set; }
//        public string description { get; set; }
//        public string alternates { get; set; }
//        public string value { get; set; }
//        public string subtag { get; set; }
//        public string iso639_3Tag { get; set; }
//        public string type { get; set; }
//        public string alias { get; set; }
//        public bool enabled { get; set; }
//    }

//    public class Number
//    {
//        public int id { get; set; }
//        public string parsedNumber { get; set; }
//        public string numberFormatted { get; set; }
//        public string countryCode { get; set; }
//        public string areaCode { get; set; }
//        public string number { get; set; }
//        public int typeid { get; set; }
//        public bool primaryNumber { get; set; }
//    }

//    public class Address
//    {
//        public int id { get; set; }
//        public string clientid { get; set; }
//        public string clientLabel { get; set; }
//        public int companyid { get; set; }
//        public string customerid { get; set; }
//        public string customerBillingid { get; set; }
//        public string displayLabel { get; set; }
//        public string description { get; set; }
//        public string notes { get; set; }
//        public string addrEntered { get; set; }
//        public string addrFormatted { get; set; }
//        public string aptUnit { get; set; }
//        public string preamble { get; set; }
//        public string street1 { get; set; }
//        public string street2 { get; set; }
//        public string street3 { get; set; }
//        public string cityTown { get; set; }
//        public string stateCounty { get; set; }
//        public string postalCode { get; set; }
//        public string country { get; set; }
//        public bool primaryAddress { get; set; }
//        public bool valid { get; set; }
//        public string validationStatus { get; set; }
//        public bool validated { get; set; }
//        public int typeid { get; set; }
//        public float lat { get; set; }
//        public float lng { get; set; }
//        public string addressPhone { get; set; }
//        public string addressFax { get; set; }
//        public string addressEmail { get; set; }
//        public string contactPerson { get; set; }
//        public string costCenter { get; set; }
//        public bool active { get; set; }
//        public string parentid { get; set; }
//        public string parentlabel { get; set; }
//        public string publicNotes { get; set; }
//        public string regionid { get; set; }
//        public string billingRegionid { get; set; }
//        public string costCenterName { get; set; }
//        public string timeZone { get; set; }
//    }

//    public class Email
//    {
//        public int id { get; set; }
//        public string emailAddress { get; set; }
//        public string addressVerified { get; set; }
//        public string dateVerified { get; set; }
//        public bool primaryEmail { get; set; }
//        public int typeid { get; set; }
//    }

//}
