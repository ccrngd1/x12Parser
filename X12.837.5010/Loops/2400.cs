using System;
using System.Collections.Generic;
namespace X12._837._5010.Loops
{
	public class 2400
	{
		public LX LineNumber{get;set;}
		public SV1 ProfessionalService{get;set;}
		public SV5 MedicalEqupmentService{get;set;}
		public PWK LineSupplemental{get;set;}
		public PWK EquipmentCertificateIndicator{get;set;}
		public CR1 AmbulanceTransport{get;set;}
		public CR3 MedicalEquipmentCertification{get;set;}
		public CRC AmbulanceCertification{get;set;}
		public CRC HospiceEmployeeIndicator{get;set;}
		public CRC EquipmentConditionIndicator{get;set;}
		public DTP ServiceDate{get;set;}
		public DTP Perscription{get;set;}
		public DTP CertificationRevision{get;set;}
		public DTP BeginTherapy{get;set;}
		public DTP LastCertificationDate{get;set;}
		public DTP LastSeen{get;set;}
		public DTP Test{get;set;}
		public DTP Shipped{get;set;}
		public DTP LastXRay{get;set;}
		public DTP InitialTreatment{get;set;}
		public QTY AmbulancePatientcount{get;set;}
		public QTY ObstetricAnesthesiaAdditionalUnits{get;set;}
		public MEA TestResults{get;set;}
		public CN1 Contact{get;set;}
		public REF RepricdLineItemNumber{get;set;}
		public REF AdujstedRepricedLineNumber{get;set;}
		public REF PriorAuthorization{get;set;}
		public REF LineItemControlNumber{get;set;}
		public REF MammographyCertificationNumber{get;set;}
		public REF CLIANumber{get;set;}
		public REF CLIAId{get;set;}
		public REF ImmunizationBatch{get;set;}
		public REF ReferralNumber{get;set;}
		public AMT SalesTax{get;set;}
		public AMT PostageClaimed{get;set;}
		public K3 FileInfo{get;set;}
		public NTE LineNote{get;set;}
		public NTE ThirdPartyNotes{get;set;}
		public PS1 PurchasedServiceInfo{get;set;}
		public HCP LinePricing{get;set;}
		public  {get;set;}
	}
}
