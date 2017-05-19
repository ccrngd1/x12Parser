using System;
using System.Collections.Generic;
namespace X12._837._5010.Loops
{
	public class 2320
	{
		public SBR Info{get;set;}
		public CAS Adjustments{get;set;}
		public AMT COBPayerPaid{get;set;}
		public AMT COBTotalNonCovered{get;set;}
		public AMT RemainingPatientLiability{get;set;}
		public IO OtherCoverageInfo{get;set;}
		public MOA OutpatientAdjudicaiton{get;set;}
	}
}
