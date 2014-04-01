using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cfpb.Hdma.Lar
{
	public class LarObject
	{
		/// <summary>
		/// A code representing the action taken on the loan or application, such as whether an application was approved or denied. Loan originated means the application resulted in a mortgage. Loan purchased means that the lender bought the loan on the secondary market.	
		/// </summary>
		[JsonProperty(Fields.ActionTaken)]
		public int ActionTaken { get; set; }

		/// <summary>
		/// A description of the action taken.	
		/// </summary>
		[JsonProperty(Fields.ActionTakenName)]
		public string ActionTakenName { get; set; }

		/// <summary>
		/// The abbreviated name of the federal agency.	
		/// </summary>
		[JsonProperty(Fields.AgencyAbbr)]
		public string AgencyAbbr { get; set; }

		/// <summary>
		/// A code representing the federal agency to which the HMDA-reporting institution submits its HMDA data.	
		/// </summary>
		[JsonProperty(Fields.AcencyCode)]
		public string AcencyCode { get; set; }

		/// <summary>
		/// The full name of the federal agency.
		/// </summary>
		[JsonProperty(Fields.AcencyName)]
		public string AcencyName { get; set; }

		/// <summary>
		/// A code representing the ethnicity of the primary applicant.	
		/// </summary>
		[JsonProperty(Fields.ApplicantEthnicity)]
		public int ApplicantEthnicity { get; set; }

		/// <summary>
		/// The ethnicity of the primary applicant.	
		/// </summary>
		[JsonProperty(Fields.ApplicantEthnicityName)]
		public string ApplicantEthnicityName { get; set; }

		/// <summary>
		/// The gross annual income that the lender relied on when evaluating the creditworthiness of the applicant, rounded to the nearest thousand.	
		/// </summary>
		[JsonProperty(Fields.ApplicantIncome000s)]
		public int ApplicantIncome000s { get; set; }

		/// <summary>
		/// A code representing the first listed race for the primary applicant. The applicant can list up to five races.	
		/// </summary>
		[JsonProperty(Fields.ApplicantRace1)]
		public int ApplicantRace1 { get; set; }

		/// <summary>
		/// A code representing the second listed race for the primary applicant.	
		/// </summary>
		[JsonProperty(Fields.ApplicantRace2)]
		public int ApplicantRace2 { get; set; }

		/// <summary>
		/// A code representing the third listed race for the primary applicant.	
		/// </summary>
		[JsonProperty(Fields.ApplicantRace3)]
		public int ApplicantRace3 { get; set; }

		/// <summary>
		/// A code representing the fourth listed race for the primary applicant.	
		/// </summary>
		[JsonProperty(Fields.ApplicantRace4)]
		public int ApplicantRace4 { get; set; }

		/// <summary>
		/// A code representing the fifth listed race for the primary applicant.	
		/// </summary>
		[JsonProperty(Fields.ApplicantRace5)]
		public int ApplicantRace5 { get; set; }

		/// <summary>
		/// The first listed race for the primary applicant. The applicant can list up to five races.	
		/// </summary>
		[JsonProperty(Fields.ApplicantRaceName1)]
		public string ApplicantRaceName1 { get; set; }

		/// <summary>
		/// The second listed race for the primary applicant.	
		/// </summary>
		[JsonProperty(Fields.ApplicantRaceName2)]
		public string ApplicantRaceName2 { get; set; }

		/// <summary>
		/// The third listed race for the primary applicant.	
		/// </summary>
		[JsonProperty(Fields.ApplicantRaceName3)]
		public string ApplicantRaceName3 { get; set; }

		/// <summary>
		/// The fourth listed race for the primary applicant.	
		/// </summary>
		[JsonProperty(Fields.ApplicantRaceName4)]
		public string ApplicantRaceName4 { get; set; }

		/// <summary>
		/// The fifth listed race for the primary applicant.	
		/// </summary>
		[JsonProperty(Fields.ApplicantRaceName5)]
		public string ApplicantRaceName5 { get; set; }

		/// <summary>
		/// A code representing the sex of the primary applicant.	
		/// </summary>
		[JsonProperty(Fields.ApplicantSex)]
		public int ApplicantSex { get; set; }

		/// <summary>
		/// The sex of the primary applicant.	
		/// </summary>
		[JsonProperty(Fields.ApplicantSexName)]
		public string ApplicantSexName { get; set; }

		/// <summary>
		/// A code representing the date of the application. "0" means the application was made on or after 1/1/2004; "1" means the application was made before 1/1/2004; "2" means the application date is not available.	
		/// </summary>
		[JsonProperty(Fields.ApplicationDateIndicator)]
		public int ApplicationDateIndicator { get; set; }

		/// <summary>
		/// The reporting year of the HMDA record.	
		/// </summary>
		[JsonProperty(Fields.AsOfYear)]
		public int AsOfYear { get; set; }

		/// <summary>
		/// The number of the census tract for the property. This code is only unique when combined with the state and county codes.	
		/// </summary>
		[JsonProperty(Fields.CensusTractNumber)]
		public string CensusTractNumber { get; set; }

		/// <summary>
		/// A code representing the ethnicity of the co-applicant.	
		/// </summary>
		[JsonProperty(Fields.CoApplicantEthnicity)]
		public int CoApplicantEthnicity { get; set; }

		/// <summary>
		/// The ethnicity of the co-applicant.	
		/// </summary>
		[JsonProperty(Fields.CoApplicantEthnicityName)]
		public string CoApplicantEthnicityName { get; set; }

		/// <summary>
		/// A code representing the first listed race for the co-applicant. The co-applicant can list up to five races.	
		/// </summary>
		[JsonProperty(Fields.CoApplicantRace1)]
		public int CoApplicantRace1 { get; set; }

		/// <summary>
		/// A code representing the second listed race for the co-applicant.	
		/// </summary>
		[JsonProperty(Fields.CoApplicantRace2)]
		public int CoApplicantRace2 { get; set; }

		/// <summary>
		/// A code representing the third listed race for the co-applicant.	
		/// </summary>
		[JsonProperty(Fields.CoApplicantRace3)]
		public int CoApplicantRace3 { get; set; }

		/// <summary>
		/// A code representing the fourth listed race for the co-applicant.	
		/// </summary>
		[JsonProperty(Fields.CoApplicantRace4)]
		public int CoApplicantRace4 { get; set; }

		/// <summary>
		/// A code representing the fifth listed race for the co-applicant.	
		/// </summary>
		[JsonProperty(Fields.CoApplicantRace5)]
		public int CoApplicantRace5 { get; set; }

		/// <summary>
		/// The first listed race for the co-applicant. The co-applicant can list up to five races.	
		/// </summary>
		[JsonProperty(Fields.CoApplicantRaceName1)]
		public string CoApplicantRaceName1 { get; set; }

		/// <summary>
		/// The second listed race for the co-applicant.	
		/// </summary>
		[JsonProperty(Fields.CoApplicantRaceName2)]
		public string CoApplicantRaceName2 { get; set; }

		/// <summary>
		/// The third listed race for the co-applicant.	
		/// </summary>
		[JsonProperty(Fields.CoApplicantRaceName3)]
		public string CoApplicantRaceName3 { get; set; }

		/// <summary>
		/// The fourth listed race for the co-applicant.	
		/// </summary>
		[JsonProperty(Fields.CoApplicantRaceName4)]
		public string CoApplicantRaceName4 { get; set; }

		/// <summary>
		/// The fifth listed race for the co-applicant.	
		/// </summary>
		[JsonProperty(Fields.CoApplicantRaceName5)]
		public string CoApplicantRaceName5 { get; set; }

		/// <summary>
		/// A code representing the sex of the co-applicant.	
		/// </summary>
		[JsonProperty(Fields.CoApplicantSex)]
		public int CoApplicantSex { get; set; }

		/// <summary>
		/// The sex of the co-applicant.	
		/// </summary>
		[JsonProperty(Fields.CoApplicantSexName)]
		public string CoApplicantSexName { get; set; }

		/// <summary>
		/// A three-digit code representing the county of the property. This code is only unique when combined with the state code.	
		/// </summary>
		[JsonProperty(Fields.CountyCode)]
		public int CountyCode { get; set; }

		/// <summary>
		/// The name of the county containing the property. Some counties have the same name, so we recommend combining this with state.	
		/// </summary>
		[JsonProperty(Fields.CountyName)]
		public string CountyName { get; set; }

		/// <summary>
		/// A code representing the first reason for denial of the application. Lenders may report up to three denial reasons, but such reporting is optional.	
		/// </summary>
		[JsonProperty(Fields.DenialReason1)]
		public int? DenialReason1 { get; set; }

		/// <summary>
		/// A code representing the second reason for denial of the application.	
		/// </summary>
		[JsonProperty(Fields.DenialReason2)]
		public int? DenialReason2 { get; set; }

		/// <summary>
		/// A code representing the third reason for denial of the application.	
		/// </summary>
		[JsonProperty(Fields.DenialReason3)]
		public int? DenialReason3 { get; set; }

		/// <summary>
		/// The first reason for denial of the application. Lenders may report up to three denial reasons, but such reporting is optional.	
		/// </summary>
		[JsonProperty(Fields.DenialReasonName1)]
		public string DenialReasonName1 { get; set; }

		/// <summary>
		/// The second reason for denial of the application.	
		/// </summary>
		[JsonProperty(Fields.DenialReasonName2)]
		public string DenialReasonName2 { get; set; }

		/// <summary>
		/// The third reason for denial of the application.	
		/// </summary>
		[JsonProperty(Fields.DenialReasonName3)]
		public string DenialReasonName3 { get; set; }

		/// <summary>
		/// A code representing the edit failure status of the application.	
		/// </summary>
		[JsonProperty(Fields.EditStatus)]
		public int EditStatus { get; set; }

		/// <summary>
		/// The edit failure status of the application.	
		/// </summary>
		[JsonProperty(Fields.EditStatusName)]
		public string EditStatusName { get; set; }

		/// <summary>
		/// A code representing whether a loan is subject to the Home Ownership and Equity Protection Act of 1994 (HOEPA).	
		/// </summary>
		[JsonProperty(Fields.HoepaStatus)]
		public int HoepaStatus { get; set; }

		/// <summary>
		/// The HOEPA status of the application.	
		/// </summary>
		[JsonProperty(Fields.HoepaStatusName)]
		public string HoepaStatusName { get; set; }

		/// <summary>
		/// The median family income in dollars for the MSA/MD in which the tract is located.	
		/// </summary>
		[JsonProperty(Fields.HudMedianFamilyIncome)]
		public int HudMedianFamilyIncome { get; set; }

		/// <summary>
		/// A code representing the lien status. Most mortgages are secured by a lien against the property. In the event of a forced liquidation, first lien holders will generally get paid before subordinate lien holders.	
		/// </summary>
		[JsonProperty(Fields.LienStatus)]
		public int LienStatus { get; set; }

		/// <summary>
		/// The lien status.	
		/// </summary>
		[JsonProperty(Fields.LienStatusName)]
		public string LienStatusName { get; set; }

		/// <summary>
		/// The amount of the loan applied for, in thousands of dollars.	
		/// </summary>
		[JsonProperty(Fields.LoanAmount000s)]
		public int LoanAmount000s { get; set; }

		/// <summary>
		/// A code representing the purpose of the loan (home purchase, refinance, or home improvement).	
		/// </summary>
		[JsonProperty(Fields.LoanPurpose)]
		public int LoanPurpose { get; set; }

		/// <summary>
		/// The purpose of the loan.	
		/// </summary>
		[JsonProperty(Fields.LoanPurposeNme)]
		public string LoanPurposeNme { get; set; }

		/// <summary>
		/// A code representing the type of loan applied for. Many loans are insured or guaranteed by government programs offered by Federal Housing Administration (FHA), the Department of Veterans Affairs (VA), or the Department of Agriculture's Rural Housing Service (RHS) or Farm Service Agency (FSA). All other loans are classified as conventional.	
		/// </summary>
		[JsonProperty(Fields.LoanType)]
		public int LoanType { get; set; }

		/// <summary>
		/// The type of loan applied for.	
		/// </summary>
		[JsonProperty(Fields.LoanTypeName)]
		public string LoanTypeName { get; set; }

		/// <summary>
		/// The percentage of minority population to total population for the census tract, carried to two decimal places.	
		/// </summary>
		[JsonProperty(Fields.MinorityPopulation)]
		public string MinorityPopulation { get; set; }

		/// <summary>
		/// A code representing the Metropolitian Statistical Area/Metropolitian Division (MSA/MD) the property is located in. An MSA is a region with relatively high population density at its core (usually a single large city) and close economic ties throughout. Larger MSAs are divided into MDs.	
		/// </summary>
		[JsonProperty(Fields.Msamd)]
		public string Msamd { get; set; }

		/// <summary>
		/// The Metropolitian Statistical Area/Metropolitian Division (MSA/MD) the property is located in.	
		/// </summary>
		[JsonProperty(Fields.MsamdName)]
		public string MsamdName { get; set; }

		/// <summary>
		/// The number of dwellings in the tract that are built to house fewer than 5 families.	
		/// </summary>
		[JsonProperty(Fields.NumberOf1To4FamilyUnits)]
		public int NumberOf1To4FamilyUnits { get; set; }

		/// <summary>
		/// The number of dwellings in the tract that are lived in by the owner.	
		/// </summary>
		[JsonProperty(Fields.NumberOfOwnerOccupiedUnits)]
		public int NumberOfOwnerOccupiedUnits { get; set; }

		/// <summary>
		/// A code representing the owner-occupancy status of the property. Second homes, vacation homes, and rental properties are classified as "not owner-occupied as a principal dwelling".	
		/// </summary>
		[JsonProperty(Fields.OwnerOccupancy)]
		public int OwnerOccupancy { get; set; }

		/// <summary>
		/// The owner-occupancy status of the property.	
		/// </summary>
		[JsonProperty(Fields.OwnerOccupancyName)]
		public string OwnerOccupancyName { get; set; }

		/// <summary>
		/// The total population in the tract.	
		/// </summary>
		[JsonProperty(Fields.Population)]
		public int Population { get; set; }

		/// <summary>
		/// A code representing the pre-approval status of the application.	
		/// </summary>
		[JsonProperty(Fields.Preapproval)]
		public int Preapproval { get; set; }

		/// <summary>
		/// The pre-approval status of the application.	
		/// </summary>
		[JsonProperty(Fields.PreapprovalName)]
		public string PreapprovalName { get; set; }

		/// <summary>
		/// A code representing the type of the property.	
		/// </summary>
		[JsonProperty(Fields.PropertyType)]
		public int PropertyType { get; set; }

		/// <summary>
		/// The type of the property.	
		/// </summary>
		[JsonProperty(Fields.PropertyTypeName)]
		public string PropertyTypeName { get; set; }

		/// <summary>
		/// A code representing the type of institution purchasing the loan.	
		/// </summary>
		[JsonProperty(Fields.PurchaserType)]
		public string PurchaserType { get; set; }

		/// <summary>
		/// The type of institution purchasing the loan.	
		/// </summary>
		[JsonProperty(Fields.PurchaserTypeName)]
		public string PurchaserTypeName { get; set; }

		/// <summary>
		/// The rate spread for the loan, which is the difference between the loan's annual percentage rate (APR) and the average prime offer rate (APOR).	
		/// </summary>
		[JsonProperty(Fields.RateSpread)]
		public string RateSpread { get; set; }

		/// <summary>
		/// A code representing the bank or other financial institution that is reporting the loan or application.	
		/// </summary>
		[JsonProperty(Fields.RespondentId)]
		public string RespondentId { get; set; }

		/// <summary>
		/// A one-up number scheme for each respondent to make each loan unique.	
		/// </summary>
		[JsonProperty(Fields.SequenceNumber)]
		public string SequenceNumber { get; set; }

		/// <summary>
		/// The two-letter abbreviation for the state the property is located in.	
		/// </summary>
		[JsonProperty(Fields.StateAbbr)]
		public string StateAbbr { get; set; }

		/// <summary>
		/// A two-digit code representing the state the property is located in.	
		/// </summary>
		[JsonProperty(Fields.StateCode)]
		public string StateCode { get; set; }

		/// <summary>
		/// The name of the state the property is located in.	
		/// </summary>
		[JsonProperty(Fields.StateName)]
		public string StateName { get; set; }

		/// <summary>
		/// The percentage of the median family income for the tract compared to the median family income for the MSA/MD, rounded to two decimal places.	
		/// </summary>
		[JsonProperty(Fields.TractToMsamdIncome)]
		public string TractToMsamdIncome { get; set; }
	}
}
