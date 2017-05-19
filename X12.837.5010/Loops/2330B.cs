using System;
using System.Collections.Generic;
namespace X12._837._5010.Loops
{
	public class 2330B
	{
		public NM1 Name{get;set;}
		public N3 Address{get;set;}
		public N4 Location{get;set;}
		public DTP CheckRemittanceDate{get;set;}
		public REF SecondaryId{get;set;}
		public REF AuthorizationNumber{get;set;}
		public REF ReferalNumber{get;set;}
		public REF AdjustmentIndicator{get;set;}
		public REF ControlNumber{get;set;}
	}
}
