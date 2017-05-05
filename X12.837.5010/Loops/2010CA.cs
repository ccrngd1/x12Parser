using System;
using System.Collections.Generic;
namespace X12._837._5010.Loops
{
	public class 2010CA
	{
		public NM1 Name{get;set;}
		public N3 Address{get;set;}
		public N4 Location{get;set;}
		public DMG Demographic{get;set;}
		public REF PropertyCausualtyClaimNumber{get;set;}
		public REF PropertyCausualtyPatientId{get;set;}
		public PER PropertyCausualtySubscriberContact{get;set;}
	}
}
