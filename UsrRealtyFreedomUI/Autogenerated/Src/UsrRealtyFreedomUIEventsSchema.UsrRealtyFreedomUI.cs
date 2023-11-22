namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyFreedomUIEventsSchema

	/// <exclude/>
	public class UsrRealtyFreedomUIEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyFreedomUIEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyFreedomUIEventsSchema(UsrRealtyFreedomUIEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a7ee7948-4b3e-42ca-b550-e4ae439bc852");
			Name = "UsrRealtyFreedomUIEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5b4de164-043d-4643-a7d4-12c9bc2aabed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,203,110,219,48,16,188,235,43,22,66,14,18,96,16,201,53,110,3,212,142,83,24,8,210,34,150,115,41,122,160,169,181,194,130,15,97,73,57,117,11,255,123,73,209,110,45,219,69,187,39,105,57,59,59,51,88,195,53,186,150,11,132,10,137,184,179,107,207,166,214,172,101,211,17,247,210,154,236,103,6,161,58,39,77,3,139,173,243,168,199,71,157,227,41,173,173,249,219,27,33,155,25,47,189,68,247,31,16,54,219,160,241,123,228,151,190,187,237,91,143,50,8,48,72,197,66,188,162,230,79,65,61,188,135,124,233,232,25,185,242,219,7,66,172,173,94,206,243,242,107,63,220,118,43,37,5,8,197,157,131,132,185,64,7,183,48,225,14,47,188,244,36,41,130,35,58,187,9,186,101,141,176,177,178,134,79,102,110,28,146,15,134,10,187,250,134,194,131,67,83,35,141,32,49,78,112,29,220,245,188,31,168,113,128,229,111,194,63,212,177,86,65,4,59,166,59,240,96,57,30,0,19,47,80,111,40,36,80,164,70,153,240,67,108,141,66,106,174,160,37,41,98,90,105,136,125,68,95,109,91,172,167,86,117,218,188,112,213,225,187,61,244,174,136,137,126,142,248,229,226,62,63,217,45,215,80,36,174,59,184,185,62,84,57,192,12,109,197,66,54,119,83,110,4,42,172,131,8,79,29,142,179,51,148,243,20,207,34,220,164,227,13,86,168,91,197,125,20,109,240,13,30,173,224,74,254,224,43,133,139,30,87,236,173,44,67,92,225,104,77,72,62,92,44,123,70,103,59,18,1,100,41,176,140,224,108,77,172,11,71,147,174,46,31,65,126,182,202,177,62,161,185,171,172,157,200,38,253,229,37,171,236,94,74,249,79,55,193,69,106,176,7,75,154,251,226,196,101,88,123,195,174,39,87,167,121,199,242,175,100,223,250,16,102,223,5,182,209,230,97,252,4,189,203,134,95,187,108,151,253,2,81,2,209,180,229,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7784a173-5765-f3c9-d27e-f23cc330db12"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("5b4de164-043d-4643-a7d4-12c9bc2aabed"),
				CreatedInSchemaUId = new Guid("a7ee7948-4b3e-42ca-b550-e4ae439bc852"),
				ModifiedInSchemaUId = new Guid("a7ee7948-4b3e-42ca-b550-e4ae439bc852")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a7ee7948-4b3e-42ca-b550-e4ae439bc852"));
		}

		#endregion

	}

	#endregion

}

