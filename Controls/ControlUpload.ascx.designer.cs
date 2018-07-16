using DotNetNuke;
using DotNetNuke.Common;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities;
using DotNetNuke.Framework;
using DotNetNuke.Security;
using DotNetNuke.Services;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;
using System.Web.SessionState;
using System.Web.Security;
using System.Web.Profile;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated. 
// </auto-generated>
//------------------------------------------------------------------------------


namespace DotNetNuke.Modules.Gallery.WebControls
{

	public partial class Upload
	{

		///<summary>
		///scnInstructions control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::DotNetNuke.UI.UserControls.SectionHeadControl scnInstructions;
		///<summary>
		///trInstructions control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::System.Web.UI.HtmlControls.HtmlTableRow trInstructions;
		///<summary>
		///tdInstructions control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::System.Web.UI.HtmlControls.HtmlTableCell tdInstructions;
		///<summary>
		///scnInfo control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::DotNetNuke.UI.UserControls.SectionHeadControl scnInfo;
		///<summary>
		///trInfo control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::System.Web.UI.HtmlControls.HtmlTableRow trInfo;
		///<summary>
		///tdInfo control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::System.Web.UI.HtmlControls.HtmlTableCell tdInfo;
		///<summary>
		///plAddFile control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::DotNetNuke.UI.UserControls.LabelControl plAddFile;
		///<summary>
		///htmlUploadFile control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::System.Web.UI.HtmlControls.HtmlInputFile htmlUploadFile;
		///<summary>
		///cmdAdd control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		private global::System.Web.UI.WebControls.LinkButton withEventsField_cmdAdd;
		protected global::System.Web.UI.WebControls.LinkButton cmdAdd {
			get { return withEventsField_cmdAdd; }
			set {
				if (withEventsField_cmdAdd != null) {
					withEventsField_cmdAdd.Click -= cmdAdd_Click;
				}
				withEventsField_cmdAdd = value;
				if (withEventsField_cmdAdd != null) {
					withEventsField_cmdAdd.Click += cmdAdd_Click;
				}
			}

		}
		///<summary>
		///divFileError control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::System.Web.UI.HtmlControls.HtmlGenericControl divFileError;
		///<summary>
		///plTitle control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::DotNetNuke.UI.UserControls.LabelControl plTitle;
		///<summary>
		///txtTitle control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::System.Web.UI.WebControls.TextBox txtTitle;
		///<summary>
		///plAuthor control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::DotNetNuke.UI.UserControls.LabelControl plAuthor;
		///<summary>
		///txtAuthor control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::System.Web.UI.WebControls.TextBox txtAuthor;
		///<summary>
		///plClient control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::DotNetNuke.UI.UserControls.LabelControl plClient;
		///<summary>
		///txtClient control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::System.Web.UI.WebControls.TextBox txtClient;
		///<summary>
		///plLocation control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::DotNetNuke.UI.UserControls.LabelControl plLocation;
		///<summary>
		///txtLocation control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::System.Web.UI.WebControls.TextBox txtLocation;
		///<summary>
		///plDescription control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::DotNetNuke.UI.UserControls.LabelControl plDescription;
		///<summary>
		///txtDescription control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::System.Web.UI.WebControls.TextBox txtDescription;
		///<summary>
		///plCategories control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::DotNetNuke.UI.UserControls.LabelControl plCategories;
		///<summary>
		///lstCategories control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::System.Web.UI.WebControls.CheckBoxList lstCategories;
		///<summary>
		///trPendingUploads control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::System.Web.UI.HtmlControls.HtmlTableRow trPendingUploads;
		///<summary>
		///plAddedFiles control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::DotNetNuke.UI.UserControls.LabelControl plAddedFiles;
		///<summary>
		///lblUpload control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>

		protected global::System.Web.UI.WebControls.Label lblUpload;
		///<summary>
		///grdUpload control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		private global::System.Web.UI.WebControls.DataGrid withEventsField_grdUpload;
        protected global::System.Web.UI.WebControls.DataGrid grdUpload;
		///<summary>
		///btnFileUpload control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		private global::System.Web.UI.WebControls.LinkButton withEventsField_btnFileUpload;
		protected global::System.Web.UI.WebControls.LinkButton btnFileUpload {
			get { return withEventsField_btnFileUpload; }
			set {
				if (withEventsField_btnFileUpload != null) {
					withEventsField_btnFileUpload.Click -= btnFileUpload_Click;
				}
				withEventsField_btnFileUpload = value;
				if (withEventsField_btnFileUpload != null) {
					withEventsField_btnFileUpload.Click += btnFileUpload_Click;
				}
			}

		}
		///<summary>
		///cmdReturnCancel control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		private global::System.Web.UI.WebControls.LinkButton withEventsField_cmdReturnCancel;
		protected global::System.Web.UI.WebControls.LinkButton cmdReturnCancel {
			get { return withEventsField_cmdReturnCancel; }
			set {
				if (withEventsField_cmdReturnCancel != null) {
					withEventsField_cmdReturnCancel.Click -= cmdReturnCancel_Click;
				}
				withEventsField_cmdReturnCancel = value;
				if (withEventsField_cmdReturnCancel != null) {
					withEventsField_cmdReturnCancel.Click += cmdReturnCancel_Click;
				}
			}
		}
	}
}
