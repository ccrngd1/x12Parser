using System;
using System.Collections.Generic;
namespace X12._837._5010.Loops
{
	public class 2300
	{
		public CLM Claim{get;set;}
		public DTP Onset{get;set;}
		public DTP Initialtreatment{get;set;}
		public DTP LastSeen{get;set;}
		public DTP AcuteManifestation{get;set;}
		public DTP Accident{get;set;}
		public DTP LastMenstrual{get;set;}
		public DTP LastXRay{get;set;}
		public DTP HearingVisionPrescription{get;set;}
		public DTP DisabilityDates{get;set;}
		public DTP LastWored{get;set;}
		public DTP AuthorizedReturnWork{get;set;}
		public DTP Admission{get;set;}
		public DTP Discharge{get;set;}
		public DTP AssumedRelinquishedCare{get;set;}
		public DTP PropertyCasualtyFirstContact{get;set;}
		public DTP RepricerReceived{get;set;}
		public PWK SupplementalInfomation{get;set;}
		public CN1 Contact{get;set;}
		public AMT PatientAmountPaid{get;set;}
		public REF ServiceAuthorizationException{get;set;}
		public REF MandatoryMedicareCrossover{get;set;}
		public REF MammographCertificationNumber{get;set;}
		public REF ReferalNumber{get;set;}
		public REF PriorAuthorizaiton{get;set;}
		public REF PayerClaimControlNumer{get;set;}
		public REF CLIANumber{get;set;}
		public REF RepricedClaimNumber{get;set;}
		public REF AdjustedRepricedClaimNumber{get;set;}
		public REF InvestigativeDeviceExemption{get;set;}
		public REF ClaimIdForTransmissionIntermediaries{get;set;}
		public REF MedicalRecordNumber{get;set;}
		public REF DemonstrationProjectId{get;set;}
		public REF CarePlanOversight{get;set;}
		public K3 File Info{get;set;}
		public NTE Note{get;set;}
		public CR1 AmbulanceInfo{get;set;}
		public CR2 SpinalManipulaiton{get;set;}
		public CRC AmbulanceCertification{get;set;}
		public CRC PationConditionVision{get;set;}
		public CRC HomeboundIndicator{get;set;}
		public CRC EPSDTReferral{get;set;}
		public HI HealthCareDiagnosisCode{get;set;}
		public HI AnesthesiaRelatedProcedure{get;set;}
		public HI ConditionInfomation{get;set;}
		public HCP ClaimPricingInfo{get;set;}
	}
}
