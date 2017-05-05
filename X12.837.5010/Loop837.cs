using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X12.Data.Loops;

namespace X12._837._5010
{
    public class Loop837
    {
        public  LoopDefinition[] Definition
        {
            get
            {
                var gs = new LoopDefinition
                {
                    Name = "Group Start",
                    MaxRepeats = int.MaxValue,
                    Fields = new LoopField[]
                {
                    new LoopField{Segment="GS",Name = "Group Start", Qualifiers=new string[]{"005010X222A1","005010X222" }},
                    new LoopField {Segment="GE",Name="Group End" },
                }
                };
                var st = new LoopDefinition
                {
                    Name = "Segment Start",
                    MaxRepeats = int.MaxValue,
                    Fields = new LoopField[]
                    {
                        new LoopField{Segment="ST",Name = "Segment Start", Qualifiers = new string[] {"837"}},
                        new LoopField {Segment="SE",Name="Segment End" },
                    },
                    ParentLoops = new string[]{ "Group Start"}
                };
                var loopHeader = new LoopDefinition
                {
                    Name = "Header",
                    MaxRepeats = int.MaxValue,
                    Fields = new LoopField[]
                    {                       
                        new LoopField {Segment="BHT",Name="BHT" ,Required=true},                        
                    },
                    ParentLoops = new string[]{ "Segment Start"}
                };
                var loop1000A = new LoopDefinition
                {
                    Name = "1000A",
                    ParentLoops = new string[]{ "Header"},
                    MaxRepeats =1,
                    Fields = new LoopField[]
    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "41" } ,Required=true},
            new LoopField { Segment = "PER", Name = "EDIContact", Qualifiers = new string[] { "IC" },Repeats=2 },
           
    }
                };
                var loop1000B = new LoopDefinition
                {
                    Name = "1000B",
                    ParentLoops = new string[]{ "Header"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "40" } ,Required=true},
            
                    }
                };
                var loop2000A = new LoopDefinition
                {
                    Name = "2000A",
                    ParentLoops = new string[]{ "Header"},
                    MaxRepeats = int.MaxValue,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "HL", Name = "Level", Qualifiers = new string[] { "20" },Required=true },
            new LoopField { Segment = "PRV", Name = "Specialty Info", Qualifiers = new string[] { "BI" } },
            new LoopField { Segment = "CUR", Name = "Currency", Qualifiers = new string[] { "85" } },
                    }
                    
                    
                };
                
                var loop2010AA = new LoopDefinition
                {
                    Name = "2010AA",
                    ParentLoops= new string[]{"2000A"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "85" } ,Required=true},
            new LoopField { Segment = "N3", Name = "Address", Qualifiers = null },
            new LoopField { Segment = "N4", Name = "Location", Qualifiers = null },
            new LoopField { Segment = "REF", Name = "TaxId", Qualifiers = new string[] { "EI","SY" } },
            new LoopField 
            {
                Segment = "REF", 
                Name = "UPINLicense", 
                Qualifiers = new string[] //Also allowing 4010#'s
                {
                    "0B","1G","1A","1B","1C","1D",
                    "1H","1J","B3","BQ","EI","FH",
                    "G2","G5","LU","SY","U3","X5"
                } ,
                Repeats=2
            }, 
            new LoopField { Segment = "PER", Name = "ContactInfo", Qualifiers = new string[] { "IC" } ,Repeats=2},
                    }
                };
                var loop2010AB = new LoopDefinition
                {
                    Name = "2010AB",
                    ParentLoops = new string[]{ "2000A"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "87" },Required=true },
            new LoopField { Segment = "N3", Name = "Address", Qualifiers = null },
            new LoopField { Segment = "N4", Name = "Location", Qualifiers = null },
                    }
                };
                var loop2010AC = new LoopDefinition
                {
                    Name = "2010AC",
                    ParentLoops = new string[]{ "2000A"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "PE" } ,Required=true},
            new LoopField { Segment = "N3", Name = "Address", Qualifiers = null },
            new LoopField { Segment = "N4", Name = "Location", Qualifiers = null },
            new LoopField { Segment = "REF", Name = "SecondaryId", Qualifiers = new string[] { "2U","FY","NF" } },
            new LoopField { Segment = "REF", Name = "TaxID", Qualifiers = new string[] { "EI" } },
            new LoopField { Segment = "", Name = "", Qualifiers = null },
                    }
                };
                var loop2000B = new LoopDefinition
                {
                    Name = "2000B",
                    ParentLoops = new string[]{ "2000A"},
                    MaxRepeats=int.MaxValue,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "HL", Name = "Level", Qualifiers = new string[] { "22" },Required=true },
            new LoopField { Segment = "SBR", Name = "SubscriberInfo", Qualifiers = null },
            new LoopField { Segment = "PAT", Name = "PationInfo", Qualifiers = null },
                    }
                };
                var loop2010BA = new LoopDefinition
                {
                    Name = "2010BA",
                     ParentLoops = new string[]{ "2000B"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "IL" } ,Required=true},
            new LoopField { Segment = "N3", Name = "Address", Qualifiers = null },
            new LoopField { Segment = "N4", Name = "Location", Qualifiers = null },
            new LoopField { Segment = "DMG", Name = "Demographic", Qualifiers = null },
            new LoopField { Segment = "REF", Name = "SecondaryId", Qualifiers = new string[] { "SY" } },
            new LoopField { Segment = "REF", Name = "PropertyCausualtyClaimNumber", Qualifiers = new string[] { "Y4" } },
            new LoopField { Segment = "PER", Name = "PropertyCausualtySubscriberContact", Qualifiers = new string[] { "IC" } },
                    }
                };
                var loop2010BB = new LoopDefinition
                {
                    Name = "2010BB",
                    ParentLoops = new string[]{ "2000B"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "PR" } ,Required=true},
            new LoopField { Segment = "N3", Name = "Address", Qualifiers = null },
            new LoopField { Segment = "N4", Name = "Location", Qualifiers = null },
            new LoopField { Segment = "REF", Name = "SecondaryId", Qualifiers = new string[] { "2U","EI","FY","NF" } ,Repeats=3},
            new LoopField { Segment = "REF", Name = "BillingProviderSecondaryId", Qualifiers = new string[] { "G2","LU" } ,Repeats=2},
                    }
                };
                var loop2000C = new LoopDefinition
                {
                    Name = "2000C",
                    ParentLoops = new string[]{ "2000B"},
                    MaxRepeats=1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "HL", Name = "Level", Qualifiers = new string[] { "23" } ,Required=true},
            new LoopField { Segment = "PAT", Name = "Info", Qualifiers = null },
                    }
                };
                var loop2010CA = new LoopDefinition
                {
                    Name = "2010CA",
                    ParentLoops = new string[]{ "2000C"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "QC" } ,Required=true},
            new LoopField { Segment = "N3", Name = "Address", Qualifiers = null },
            new LoopField { Segment = "N4", Name = "Location", Qualifiers = null },
            new LoopField { Segment = "DMG", Name = "Demographic", Qualifiers = null },
            new LoopField { Segment = "REF", Name = "PropertyCausualtyClaimNumber", Qualifiers = new string[] { "Y4" } },
            new LoopField { Segment = "REF", Name = "PropertyCausualtyPatientId", Qualifiers = new string[] { "1W","SY" } },
            new LoopField { Segment = "PER", Name = "PropertyCausualtySubscriberContact", Qualifiers = new string[] { "IC" } },
                    }
                };
                var loop2300 = new LoopDefinition
                {
                    Name = "2300",
                    ParentLoops = new string[]{"2000B","2000C"},
                    MaxRepeats=999,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "CLM", Name = "Claim", Qualifiers = null ,Required=true},
            new LoopField { Segment = "DTP", Name = "Onset", Qualifiers = new string[] { "431" } },
            new LoopField { Segment = "DTP", Name = "Initialtreatment", Qualifiers = new string[] { "454" } },
            new LoopField { Segment = "DTP", Name = "LastSeen", Qualifiers = new string[] { "304" } },
            new LoopField { Segment = "DTP", Name = "AcuteManifestation", Qualifiers = new string[] { "453" } },
            new LoopField { Segment = "DTP", Name = "Accident", Qualifiers = new string[] { "439" } },
            new LoopField { Segment = "DTP", Name = "LastMenstrual", Qualifiers = new string[] { "484" } },
            new LoopField { Segment = "DTP", Name = "LastXRay", Qualifiers = new string[] { "455" } },
            new LoopField { Segment = "DTP", Name = "HearingVisionPrescription", Qualifiers = new string[] { "471" } },
            new LoopField { Segment = "DTP", Name = "DisabilityDates", Qualifiers = new string[] { "314360361" } },
            new LoopField { Segment = "DTP", Name = "LastWored", Qualifiers = new string[] { "297" } },
            new LoopField { Segment = "DTP", Name = "AuthorizedReturnWork", Qualifiers = new string[] { "296" } },
            new LoopField { Segment = "DTP", Name = "Admission", Qualifiers = new string[] { "435" } },
            new LoopField { Segment = "DTP", Name = "Discharge", Qualifiers = new string[] { "096" } },
            new LoopField { Segment = "DTP", Name = "AssumedRelinquishedCare", Qualifiers = new string[] { "090","091" } },
            new LoopField { Segment = "DTP", Name = "PropertyCasualtyFirstContact", Qualifiers = new string[] { "444" } },
            new LoopField { Segment = "DTP", Name = "RepricerReceived", Qualifiers = new string[] { "050" } },
            new LoopField { Segment = "PWK", Name = "SupplementalInfomation", Qualifiers = null ,Repeats=10},
            new LoopField { Segment = "CN1", Name = "Contact", Qualifiers = null },
            new LoopField { Segment = "AMT", Name = "PatientAmountPaid", Qualifiers = null },
            new LoopField { Segment = "REF", Name = "ServiceAuthorizationException", Qualifiers = new string[] { "4N" } },
            new LoopField { Segment = "REF", Name = "MandatoryMedicareCrossover", Qualifiers = new string[] { "F5" } },
            new LoopField { Segment = "REF", Name = "MammographCertificationNumber", Qualifiers = new string[] { "EW" } },
            new LoopField { Segment = "REF", Name = "ReferalNumber", Qualifiers = new string[] { "9F" } },
            new LoopField { Segment = "REF", Name = "PriorAuthorizaiton", Qualifiers = new string[] { "G1" } },
            new LoopField { Segment = "REF", Name = "PayerClaimControlNumer", Qualifiers = new string[] { "F8" } },
            new LoopField { Segment = "REF", Name = "CLIANumber", Qualifiers = new string[] { "X4" } },
            new LoopField { Segment = "REF", Name = "RepricedClaimNumber", Qualifiers = new string[] { "9A" } },
            new LoopField { Segment = "REF", Name = "AdjustedRepricedClaimNumber", Qualifiers = new string[] { "9C" } },
            new LoopField { Segment = "REF", Name = "InvestigativeDeviceExemption", Qualifiers = new string[] { "LX" } },
            new LoopField { Segment = "REF", Name = "ClaimIdForTransmissionIntermediaries", Qualifiers = new string[] { "D9" } },
            new LoopField { Segment = "REF", Name = "MedicalRecordNumber", Qualifiers = new string[] { "EA" } },
            new LoopField { Segment = "REF", Name = "DemonstrationProjectId", Qualifiers = new string[] { "P4" } },
            new LoopField { Segment = "REF", Name = "CarePlanOversight", Qualifiers = new string[] { "1J" } },
            new LoopField { Segment = "K3", Name = "File Info", Qualifiers = null,Repeats=10 },
            new LoopField { Segment = "NTE", Name = "Note", Qualifiers = null },
            new LoopField { Segment = "CR1", Name = "AmbulanceInfo", Qualifiers = null },
            new LoopField { Segment = "CR2", Name = "SpinalManipulaiton", Qualifiers = null },
            new LoopField { Segment = "CRC", Name = "AmbulanceCertification", Qualifiers = new string[] { "07" },Repeats=3 },
            new LoopField { Segment = "CRC", Name = "PationConditionVision", Qualifiers = new string[] { "E1","E2","E3" },Repeats=3 },
            new LoopField { Segment = "CRC", Name = "HomeboundIndicator", Qualifiers = new string[] { "75" } },
            new LoopField { Segment = "CRC", Name = "EPSDTReferral", Qualifiers = new string[] { "ZZ" } },
            new LoopField { Segment = "HI", Name = "HealthCareDiagnosisCode", Qualifiers = null },
            new LoopField { Segment = "HI", Name = "AnesthesiaRelatedProcedure", Qualifiers = null },
            new LoopField { Segment = "HI", Name = "ConditionInfomation", Qualifiers = null,Repeats=2 },
            new LoopField { Segment = "HCP", Name = "ClaimPricingInfo", Qualifiers = null },
                    }
                };
                var loop2310A = new LoopDefinition
                {
                    Name = "2310A",
                    ParentLoops = new string[]{ "2300"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "DN" },Required=true },
            new LoopField { Segment = "REF", Name = "SecondaryId", Qualifiers = new string[] { "0B","1G"  ,"1B","1C","1D","1H","EI","N5","SY","X5"} //Let4010 slide
            ,Repeats=3 },
                    }
                };
                var loop2310B = new LoopDefinition
                {
                    Name = "2310B",
                    ParentLoops = new string[]{ "2300"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "82" },Required=true },
            new LoopField { Segment = "PRV", Name = "SpecialtyInfo", Qualifiers = new string[] { "PE" } },
            new LoopField { Segment = "REF", Name = "SecondaryId", Qualifiers = new string[] { "0B","1G","G2","LU",
          "1B","1C","1D","1H","EI","N5","SY","X5"} //Let4010 slide}
            ,Repeats=4},
                    }
                };
                var loop2310C = new LoopDefinition
                {
                    Name = "2310C",
                    ParentLoops = new string[]{ "2300"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "77",
                "FA","LI","TL" },//4010 code
            Required=true },
            new LoopField { Segment = "N3", Name = "Address", Qualifiers = null },
            new LoopField { Segment = "N4", Name = "Location", Qualifiers = null },
            new LoopField 
            {
                Segment = "REF", 
                Name = "SecondaryId", 
                Qualifiers = new string[] 
                { 
                    "0B","G2","LU" ,
                    "1A","1B","1C","1D","1G","1H","N5","TJ","X4","X5", //Let4010 slide
                } ,
                Repeats=3
            },
            new LoopField { Segment = "PER", Name = "ContactInfo", Qualifiers = new string[] { "IC" } },
                    }
                };
                var loop2310D = new LoopDefinition
                {
                    Name = "2310D",
                    ParentLoops = new string[]{ "2300"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "DQ" },Required=true },
            new LoopField { Segment = "REF", Name = "SecondaryId", Qualifiers = new string[] { "0B","1G","G2","LU" } ,Repeats = 4},
                    }
                };
                var loop2310E = new LoopDefinition
                {
                    Name = "2310E",
                    ParentLoops = new string[]{ "2300"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "PW" },Required=true },
            new LoopField { Segment = "N3", Name = "Address", Qualifiers = null },
            new LoopField { Segment = "N4", Name = "Locaiton", Qualifiers = null },
                    }
                };
                var loop2310F = new LoopDefinition
                {
                    Name = "2310F",
                    ParentLoops = new string[]{ "2300"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "45" },Required=true },
            new LoopField { Segment = "N3", Name = "Address", Qualifiers = null },
            new LoopField { Segment = "N4", Name = "Locaiton", Qualifiers = null },
            new LoopField { Segment = "", Name = "", Qualifiers = null },
                    }
                };
                var loop2320 = new LoopDefinition
                {
                    Name = "2320",
                    ParentLoops = new string[]{ "2300"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "SBR", Name = "Info", Qualifiers = null,Required=true },
            new LoopField { Segment = "CAS", Name = "Adjustments", Qualifiers = null,Repeats=5 },
            new LoopField { Segment = "AMT", Name = "COBPayerPaid", Qualifiers = null },
            new LoopField { Segment = "AMT", Name = "COBTotalNonCovered", Qualifiers = null },
            new LoopField { Segment = "AMT", Name = "RemainingPatientLiability", Qualifiers = null },
            new LoopField { Segment = "OI", Name = "OtherCoverageInfo", Qualifiers = null },
            new LoopField { Segment = "MOA", Name = "OutpatientAdjudicaiton", Qualifiers = null },
                    }
                };
                var loop2330A = new LoopDefinition
                {
                    Name = "2330A",
                    ParentLoops = new string[]{ "2320"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "IL" } ,Required=true},
            new LoopField { Segment = "N3", Name = "Address", Qualifiers = null },
            new LoopField { Segment = "N4", Name = "Location", Qualifiers = null },
            new LoopField { Segment = "REF", Name = "SecondaryId", Qualifiers = new string[] { "SY" } },
                    }
                };
                var loop2330B = new LoopDefinition
                {
                    Name = "2330B",
                    ParentLoops = new string[]{ "2320"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "PR" } ,Required=true},
            new LoopField { Segment = "N3", Name = "Address", Qualifiers = null },
            new LoopField { Segment = "N4", Name = "Location", Qualifiers = null },
            new LoopField { Segment = "DTP", Name = "CheckRemittanceDate", Qualifiers = new string[] { "573" } },
            new LoopField { Segment = "REF", Name = "SecondaryId", Qualifiers = new string[] { "2U","EI","FY","NF" },Repeats=2 },
            new LoopField { Segment = "REF", Name = "AuthorizationNumber", Qualifiers = new string[] { "G1" } },
            new LoopField { Segment = "REF", Name = "ReferalNumber", Qualifiers = new string[] { "9F" } },
            new LoopField { Segment = "REF", Name = "AdjustmentIndicator", Qualifiers = new string[] { "T4" } },
            new LoopField { Segment = "REF", Name = "ControlNumber", Qualifiers = new string[] { "F8" } },
                    }
                };
                var loop2330C = new LoopDefinition
                {
                    Name = "2330C",
                    ParentLoops = new string[]{ "2320"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "DN","P3" },Required=true },
            new LoopField { Segment = "REF", Name = "SecondaryId", Qualifiers = new string[] { "0B","1G","G2" },Repeats=3 },
                    }
                };
                var loop2330D = new LoopDefinition
                {
                    Name = "2330D",
                    ParentLoops = new string[]{ "2320"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "82" },Required=true },
            new LoopField { Segment = "REF", Name = "SecondaryId", Qualifiers = new string[] { "0B","1G","G2","LU" },Repeats=3 },
                    }
                };
                var loop2330E = new LoopDefinition
                {
                    Name = "2330E",
                    ParentLoops = new string[]{ "2320"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "77" },Required=true },
            new LoopField { Segment = "REF", Name = "SecondaryId", Qualifiers = new string[] { "0B","G2","LU" },Repeats=3 },
                    }
                };
                var loop2330F = new LoopDefinition
                {
                    Name = "2330F",
                    ParentLoops = new string[]{ "2320"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "DQ" } ,Required=true},
            new LoopField { Segment = "REF", Name = "SecondaryId", Qualifiers = new string[] { "0B","1G","G2","LU" },Repeats=3 },
                    }
                };
                var loop2330G = new LoopDefinition
                {
                    Name = "2330G",
                    ParentLoops = new string[]{ "2320"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "85" } ,Required=true},
            new LoopField { Segment = "REF", Name = "SecondaryId", Qualifiers = new string[] { "G2","LU" },Repeats=2 },
           
                    }
                };
                var loop2400 = new LoopDefinition
                {
                    Name = "2400",
                    ParentLoops = new string[]{ "2300"},
                    MaxRepeats = 50,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "LX", Name = "LineNumber", Qualifiers = null ,Required=true},
            new LoopField { Segment = "SV1", Name = "ProfessionalService", Qualifiers = null },
            new LoopField { Segment = "SV5", Name = "MedicalEqupmentService", Qualifiers = null },
            new LoopField { Segment = "PWK", Name = "LineSupplemental", Qualifiers = null,Repeats=10 },
            new LoopField { Segment = "PWK", Name = "EquipmentCertificateIndicator", Qualifiers = new string[] { "CT" } },
            new LoopField { Segment = "CR1", Name = "AmbulanceTransport", Qualifiers = null },
            new LoopField { Segment = "CR3", Name = "MedicalEquipmentCertification", Qualifiers = null },
            new LoopField { Segment = "CRC", Name = "AmbulanceCertification", Qualifiers = new string[] { "7" },Repeats=3 },
            new LoopField { Segment = "CRC", Name = "HospiceEmployeeIndicator", Qualifiers = new string[] { "70" } },
            new LoopField { Segment = "CRC", Name = "EquipmentConditionIndicator", Qualifiers = new string[] { "9" } },
            new LoopField { Segment = "DTP", Name = "ServiceDate", Qualifiers = new string[] { "472" } },
            new LoopField { Segment = "DTP", Name = "Perscription", Qualifiers = new string[] { "471" } },
            new LoopField { Segment = "DTP", Name = "CertificationRevision", Qualifiers = new string[] { "607" } },
            new LoopField { Segment = "DTP", Name = "BeginTherapy", Qualifiers = new string[] { "463" } },
            new LoopField { Segment = "DTP", Name = "LastCertificationDate", Qualifiers = new string[] { "461" } },
            new LoopField { Segment = "DTP", Name = "LastSeen", Qualifiers = new string[] { "304" } },
            new LoopField { Segment = "DTP", Name = "Test", Qualifiers = new string[] { "738","739" },Repeats=2 },
            new LoopField { Segment = "DTP", Name = "Shipped", Qualifiers = new string[] { "11" } },
            new LoopField { Segment = "DTP", Name = "LastXRay", Qualifiers = new string[] { "455" } },
            new LoopField { Segment = "DTP", Name = "InitialTreatment", Qualifiers = new string[] { "454" } },
            new LoopField { Segment = "QTY", Name = "AmbulancePatientcount", Qualifiers = new string[] { "PT" } },
            new LoopField { Segment = "QTY", Name = "ObstetricAnesthesiaAdditionalUnits", Qualifiers = new string[] { "FL" } },
            new LoopField { Segment = "MEA", Name = "TestResults", Qualifiers = null,Repeats=5 },
            new LoopField { Segment = "CN1", Name = "Contact", Qualifiers = null },
            new LoopField { Segment = "REF", Name = "RepricdLineItemNumber", Qualifiers = new string[] { "9B" } },
            new LoopField { Segment = "REF", Name = "AdujstedRepricedLineNumber", Qualifiers = new string[] { "9D" } },
            new LoopField { Segment = "REF", Name = "PriorAuthorization", Qualifiers = new string[] { "G1" },Repeats=5 },
            new LoopField { Segment = "REF", Name = "LineItemControlNumber", Qualifiers = new string[] { "6R" } },
            new LoopField { Segment = "REF", Name = "MammographyCertificationNumber", Qualifiers = new string[] { "EW" } },
            new LoopField { Segment = "REF", Name = "CLIANumber", Qualifiers = new string[] { "X4" } },
            new LoopField { Segment = "REF", Name = "CLIAId", Qualifiers = new string[] { "F4" } },
            new LoopField { Segment = "REF", Name = "ImmunizationBatch", Qualifiers = new string[] { "BT" } },
            new LoopField { Segment = "REF", Name = "ReferralNumber", Qualifiers = new string[] { "9F" } ,Repeats=5},
            new LoopField { Segment = "AMT", Name = "SalesTax", Qualifiers = null },
            new LoopField { Segment = "AMT", Name = "PostageClaimed", Qualifiers = null },
            new LoopField { Segment = "K3", Name = "FileInfo", Qualifiers = null,Repeats=10 },
            new LoopField { Segment = "NTE", Name = "LineNote", Qualifiers = null },
            new LoopField { Segment = "NTE", Name = "ThirdPartyNotes", Qualifiers = null },
            new LoopField { Segment = "PS1", Name = "PurchasedServiceInfo", Qualifiers = null },
            new LoopField { Segment = "HCP", Name = "LinePricing", Qualifiers = null },
            new LoopField { Segment = "", Name = "", Qualifiers = null },
                    }
                };
                var loop2410 = new LoopDefinition
                {
                    Name = "2410",
                    ParentLoops = new string[]{ "2400"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "LIN", Name = "Indentification", Qualifiers = null ,Required=true},
            new LoopField { Segment = "CTP", Name = "Quantity", Qualifiers = null },
            new LoopField { Segment = "REF", Name = "Perscription", Qualifiers = new string[] { "VY","XZ" } },
                    }
                };
                var loop2420A = new LoopDefinition
                {
                    Name = "2420A",
                    ParentLoops = new string[]{ "2400"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "82" } ,Required=true},
            new LoopField { Segment = "PRV", Name = "Specialty", Qualifiers = new string[] { "PE" } },
            new LoopField { Segment = "REF", Name = "SecondaryId", Qualifiers = new string[] { "0B","1G","G2","LU" },Repeats=20 },
                    }
                };
                var loop2420B = new LoopDefinition
                {
                    Name = "2420B",
                    ParentLoops = new string[]{ "2400"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "QB" } ,Required=true},
            new LoopField { Segment = "REF", Name = "SecondaryInfo", Qualifiers = new string[] { "OB","1G","G2" },Repeats=20 },
                    }
                };
                var loop2420C = new LoopDefinition
                { 
                    Name = "2420C",
                    ParentLoops = new string[]{ "2400"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "77" },Required=true },
            new LoopField { Segment = "N3", Name = "Address", Qualifiers = null },
            new LoopField { Segment = "N4", Name = "Location", Qualifiers = null },
            new LoopField { Segment = "REF", Name = "SecondaryId", Qualifiers = new string[] { "G2","LU" } ,Repeats=3},
                    }
                };
                var loop2420D = new LoopDefinition
                {
                    Name = "2420D",
                    ParentLoops = new string[]{ "2400"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "DQ" } ,Required=true},
            new LoopField { Segment = "REF", Name = "SecondaryId", Qualifiers = new string[] { "OB","1G","G2","LU" },Repeats=20 },
                    }
                };
                var loop2420E = new LoopDefinition
                {
                    Name = "2420E",
                    ParentLoops = new string[]{ "2400"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "DK" } ,Required=true},
            new LoopField { Segment = "N3", Name = "Address", Qualifiers = null },
            new LoopField { Segment = "N4", Name = "Location", Qualifiers = null },
            new LoopField { Segment = "REF", Name = "SecondaryId", Qualifiers = new string[] { "0B","1G","G2" },Repeats=20 },
            new LoopField { Segment = "PER", Name = "Contact", Qualifiers = new string[] { "IC" } },
                    }
                };
                var loop2420F = new LoopDefinition
                {
                    Name = "2420F",
                    ParentLoops = new string[]{ "2400"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "DN","P3" } ,Required=true},
            new LoopField { Segment = "REF", Name = "SecondaryId", Qualifiers = new string[] { "0B","1G","G2" } },
                    }
                };
                var loop2420G = new LoopDefinition
                {
                    Name = "2420G",
                    ParentLoops = new string[]{ "2400"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "PW" } ,Required=true},
            new LoopField { Segment = "N3", Name = "Address", Qualifiers = null },
            new LoopField { Segment = "N4", Name = "Location", Qualifiers = null },
                    }
                };
                var loop2420H = new LoopDefinition
                {
                    Name = "2420H",
                    ParentLoops = new string[]{ "2400"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "NM1", Name = "Name", Qualifiers = new string[] { "45" } ,Required=true},
            new LoopField { Segment = "N3", Name = "Address", Qualifiers = null },
            new LoopField { Segment = "N4", Name = "Location", Qualifiers = null },
                    }
                };
                var loop2430 = new LoopDefinition
                {
                    Name = "2430",
                    ParentLoops = new string[]{ "2400"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "SVD", Name = "Info", Qualifiers = null,Required=true },
            new LoopField { Segment = "CAS", Name = "LineAdjustment", Qualifiers = null ,Repeats=5},
            new LoopField { Segment = "DTP", Name = "CheckRemittanceDate", Qualifiers = new string[] { "573" } },
            new LoopField { Segment = "AMT", Name = "RemainingPatientLiability", Qualifiers = null },
                    }
                };
                var loop2440 = new LoopDefinition
                {
                    Name = "2440",
                    ParentLoops = new string[]{ "2400"},
                    MaxRepeats = 1,
                    Fields = new LoopField[]
                    {
            new LoopField { Segment = "LQ", Name = "Code", Qualifiers = null,Required=true },
            new LoopField { Segment = "FRM", Name = "SupportingDocumentation", Qualifiers = null ,Repeats=99},
                    }
                };

                //loop2000A.LoopStarted += loop2000A_LoopStarted;
                //loop2000B.LoopStarted += loop2000B_LoopStarted;
                //loop2000C.LoopStarted += loop2000C_LoopStarted;
                //loop2300.LoopStarted += loop2300_LoopStarted;
                //st.Fields[0].LoopSet += STElement_Set;
                //st.Fields[1].LoopSet += SEElement_Set;

                return new LoopDefinition[] {gs,st, loopHeader,loop1000A, loop1000B, loop2000A, loop2010AA, loop2010AB, loop2010AC,
                    loop2000B, loop2010BA, loop2010BB, loop2000C, loop2010CA,
                    loop2300, loop2310A, loop2310B, loop2310C, loop2310D, loop2310E, loop2310F, loop2320,
                    loop2330A, loop2330B, loop2330C, loop2330D, loop2330E, loop2330F, loop2330G,
                    loop2400, loop2410, loop2420A, loop2420B, loop2420C, loop2420D, loop2420E, loop2420F, loop2420G, loop2420H,
                    loop2430, loop2440 };
            }
        }
     
        private static void SEElement_Set(object sender, Data.X12FieldEventArgs e)
        {
          
        }
        private BatchData _batchData = new BatchData();
        private  void STElement_Set(object sender, Data.X12FieldEventArgs e)
        {
            if(_batchData==null)
                _batchData = new BatchData();
        }

        private  void loop2000A_LoopStarted(object sender, Data.LoopEventArgs e)
        {
            
        }
        private  void loop2000B_LoopStarted(object sender, Data.LoopEventArgs e)
        {
          
        }
        private  void loop2000C_LoopStarted(object sender, Data.LoopEventArgs e)
        {
            
        }
        private Loop _lastParent = null;
        private  void loop2300_LoopStarted(object sender, Data.LoopEventArgs e)
        {
            if (e.Previous != null)
            {
                var parentLoop = e.Previous.GetAncestor("2000C");//could save efford by not starting at segment start if lastparent is ancestor of me.
                if(parentLoop==null)
                    parentLoop = e.Previous.GetAncestor("2000B");
                if (parentLoop != null)
                {
                    var claims = parentLoop.GetLoops("2300");
                    for (int i = 0; i < claims.Count; i++)
                    {
                        claims[i].Parent.RemoveChildLoop(claims[i]);
                    }
                    if (claims.Count > 0)
                    {
                        claims.Clear();                   
                    }
                    if (parentLoop != _lastParent)
                    {
                        _lastParent = parentLoop;
                        
                      //  LoopToClp.ConvertSegmentStart(parentLoop.GetAncestor("Segment Start"), _batchData);
                    }
                    else
                    {
 
                    }
                }
                else
                {
                    var subscriberLoop = e.Previous.GetAncestor("2000B");
                }
            }
        }
    }
}
