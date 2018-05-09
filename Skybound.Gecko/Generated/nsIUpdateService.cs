// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIUpdateService.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// An interface that describes an object representing a patch file that can
    /// be downloaded and applied to a version of this application so that it
    /// can be updated.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("60523512-bb69-417c-9b2c-87a0664b0bbe")]
	public interface nsIUpdatePatch
	{
		
		/// <summary>
        /// The type of this patch:
        /// "partial"      A binary difference between two application versions
        /// "complete"     A complete patch containing all of the replacement files
        /// to update to the new version
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aType);
		
		/// <summary>
        /// The type of this patch:
        /// "partial"      A binary difference between two application versions
        /// "complete"     A complete patch containing all of the replacement files
        /// to update to the new version
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aType);
		
		/// <summary>
        /// The URL this patch was being downloaded from
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aURL);
		
		/// <summary>
        /// The URL this patch was being downloaded from
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aURL);
		
		/// <summary>
        /// The final URL this patch was being downloaded from
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFinalURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aFinalURL);
		
		/// <summary>
        /// The final URL this patch was being downloaded from
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFinalURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aFinalURL);
		
		/// <summary>
        /// The hash function to use when determining this file's integrity
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHashFunctionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aHashFunction);
		
		/// <summary>
        /// The hash function to use when determining this file's integrity
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHashFunctionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aHashFunction);
		
		/// <summary>
        /// The value of the hash function named above that should be computed if
        /// this file is not corrupt.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHashValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aHashValue);
		
		/// <summary>
        /// The value of the hash function named above that should be computed if
        /// this file is not corrupt.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHashValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aHashValue);
		
		/// <summary>
        /// The size of this file, in bytes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetSizeAttribute();
		
		/// <summary>
        /// The size of this file, in bytes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSizeAttribute(uint aSize);
		
		/// <summary>
        /// The state of this patch
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aState);
		
		/// <summary>
        /// The state of this patch
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aState);
		
		/// <summary>
        /// true if this patch is currently selected as the patch to be downloaded and
        /// installed for this update transaction, false if another patch from this
        /// update has been selected.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSelectedAttribute();
		
		/// <summary>
        /// true if this patch is currently selected as the patch to be downloaded and
        /// installed for this update transaction, false if another patch from this
        /// update has been selected.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelectedAttribute([MarshalAs(UnmanagedType.U1)] bool aSelected);
		
		/// <summary>
        /// Serializes this patch object into a DOM Element
        /// @param   updates
        /// The document to serialize into
        /// @returns The DOM Element created by the serialization process
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement Serialize([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument updates);
	}
	
	/// <summary>
    /// An interface that describes an object representing an available update to
    /// the current application - this update may have several available patches
    /// from which one must be selected to download and install, for example we
    /// might select a binary difference patch first and attempt to apply that,
    /// then if the application process fails fall back to downloading a complete
    /// file-replace patch. This object also contains information about the update
    /// that the front end and other application services can use to learn more
    /// about what is going on.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2379e2e1-8eab-4084-8d8c-94ffeee56804")]
	public interface nsIUpdate
	{
		
		/// <summary>
        /// The type of update:
        /// "major"  A major new version of the Application
        /// "minor"  A minor update to the Application (e.g. security update)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aType);
		
		/// <summary>
        /// The type of update:
        /// "major"  A major new version of the Application
        /// "minor"  A minor update to the Application (e.g. security update)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aType);
		
		/// <summary>
        /// The name of the update, or "<Application Name> <Update Version>"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aName);
		
		/// <summary>
        /// The name of the update, or "<Application Name> <Update Version>"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aName);
		
		/// <summary>
        /// The string to display in the user interface for the version. If you want
        /// a real version number use appVersion.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDisplayVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDisplayVersion);
		
		/// <summary>
        /// The string to display in the user interface for the version. If you want
        /// a real version number use appVersion.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDisplayVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDisplayVersion);
		
		/// <summary>
        /// The Application version of this update.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAppVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAppVersion);
		
		/// <summary>
        /// The Application version of this update.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAppVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAppVersion);
		
		/// <summary>
        /// The Toolkit version of this update.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPlatformVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aPlatformVersion);
		
		/// <summary>
        /// The Toolkit version of this update.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPlatformVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aPlatformVersion);
		
		/// <summary>
        /// The Application version prior to the application being updated.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPreviousAppVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aPreviousAppVersion);
		
		/// <summary>
        /// The Application version prior to the application being updated.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPreviousAppVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aPreviousAppVersion);
		
		/// <summary>
        /// The Build ID of this update. Used to determine a particular build, down
        /// to the hour, minute and second of its creation. This allows the system
        /// to differentiate between several nightly builds with the same |version|
        /// for example.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBuildIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aBuildID);
		
		/// <summary>
        /// The Build ID of this update. Used to determine a particular build, down
        /// to the hour, minute and second of its creation. This allows the system
        /// to differentiate between several nightly builds with the same |version|
        /// for example.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBuildIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aBuildID);
		
		/// <summary>
        /// The URL to a page which offers details about the content of this
        /// update. Ideally, this page is not the release notes but some other page
        /// that summarizes the differences between this update and the previous,
        /// which also links to the release notes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDetailsURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDetailsURL);
		
		/// <summary>
        /// The URL to a page which offers details about the content of this
        /// update. Ideally, this page is not the release notes but some other page
        /// that summarizes the differences between this update and the previous,
        /// which also links to the release notes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDetailsURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDetailsURL);
		
		/// <summary>
        /// The URL to a page that is typically localized to display in the update
        /// prompt.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBillboardURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aBillboardURL);
		
		/// <summary>
        /// The URL to a page that is typically localized to display in the update
        /// prompt.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBillboardURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aBillboardURL);
		
		/// <summary>
        /// The URL to a HTML fragment that contains a license for this update. If
        /// this is specified, the user is shown the license file after they choose
        /// to install the update and they must agree to it before the download
        /// commences.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLicenseURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aLicenseURL);
		
		/// <summary>
        /// The URL to a HTML fragment that contains a license for this update. If
        /// this is specified, the user is shown the license file after they choose
        /// to install the update and they must agree to it before the download
        /// commences.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLicenseURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aLicenseURL);
		
		/// <summary>
        /// The URL to the Update Service that supplied this update.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetServiceURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aServiceURL);
		
		/// <summary>
        /// The URL to the Update Service that supplied this update.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetServiceURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aServiceURL);
		
		/// <summary>
        /// The channel used to retrieve this update from the Update Service.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetChannelAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aChannel);
		
		/// <summary>
        /// The channel used to retrieve this update from the Update Service.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetChannelAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aChannel);
		
		/// <summary>
        /// Whether to show the update prompt which requires user confirmation when an
        /// update is found during a background update check. This overrides the
        /// default setting to download the update in the background.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetShowPromptAttribute();
		
		/// <summary>
        /// Whether to show the update prompt which requires user confirmation when an
        /// update is found during a background update check. This overrides the
        /// default setting to download the update in the background.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShowPromptAttribute([MarshalAs(UnmanagedType.U1)] bool aShowPrompt);
		
		/// <summary>
        /// Whether to show the "No Thanks" button in the update prompt. This allows
        /// the user to never receive a notification for that specific update version
        /// again.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetShowNeverForVersionAttribute();
		
		/// <summary>
        /// Whether to show the "No Thanks" button in the update prompt. This allows
        /// the user to never receive a notification for that specific update version
        /// again.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShowNeverForVersionAttribute([MarshalAs(UnmanagedType.U1)] bool aShowNeverForVersion);
		
		/// <summary>
        /// Whether to show the survey link in the update prompt. The url must also be
        /// present in the app.update.surveyURL preference.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetShowSurveyAttribute();
		
		/// <summary>
        /// Whether to show the survey link in the update prompt. The url must also be
        /// present in the app.update.surveyURL preference.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShowSurveyAttribute([MarshalAs(UnmanagedType.U1)] bool aShowSurvey);
		
		/// <summary>
        /// Whether or not the update being downloaded is a complete replacement of
        /// the user's existing installation or a patch representing the difference
        /// between the new version and the previous version.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsCompleteUpdateAttribute();
		
		/// <summary>
        /// Whether or not the update being downloaded is a complete replacement of
        /// the user's existing installation or a patch representing the difference
        /// between the new version and the previous version.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsCompleteUpdateAttribute([MarshalAs(UnmanagedType.U1)] bool aIsCompleteUpdate);
		
		/// <summary>
        /// Whether or not the update is a security update or not. If this is true,
        /// then we present more serious sounding user interface messages to the
        /// user.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsSecurityUpdateAttribute();
		
		/// <summary>
        /// Whether or not the update is a security update or not. If this is true,
        /// then we present more serious sounding user interface messages to the
        /// user.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsSecurityUpdateAttribute([MarshalAs(UnmanagedType.U1)] bool aIsSecurityUpdate);
		
		/// <summary>
        /// When the update was installed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetInstallDateAttribute();
		
		/// <summary>
        /// When the update was installed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInstallDateAttribute(long aInstallDate);
		
		/// <summary>
        /// A message associated with this update, if any.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStatusTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aStatusText);
		
		/// <summary>
        /// A message associated with this update, if any.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStatusTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aStatusText);
		
		/// <summary>
        /// The currently selected patch for this update.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUpdatePatch GetSelectedPatchAttribute();
		
		/// <summary>
        /// The state of the selected patch:
        /// "downloading"       The update is being downloaded.
        /// "pending"           The update is ready to be applied.
        /// "applying"          The update is being applied.
        /// "succeeded"         The update was successfully applied.
        /// "download-failed"   The update failed to be downloaded.
        /// "failed"            The update failed to be applied.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aState);
		
		/// <summary>
        /// The state of the selected patch:
        /// "downloading"       The update is being downloaded.
        /// "pending"           The update is ready to be applied.
        /// "applying"          The update is being applied.
        /// "succeeded"         The update was successfully applied.
        /// "download-failed"   The update failed to be downloaded.
        /// "failed"            The update failed to be applied.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aState);
		
		/// <summary>
        /// A numeric error code that conveys additional information about the state
        /// of a failed update or failed certificate attribute check during an update
        /// check. If the update is not in the "failed" state or the certificate
        /// attribute check has not failed the value is zero.
        ///
        /// TODO: Define typical error codes (for now, see updater/errors.h and the
        /// CERT_ATTR_CHECK_FAILED_* values in nsUpdateService.js)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetErrorCodeAttribute();
		
		/// <summary>
        /// A numeric error code that conveys additional information about the state
        /// of a failed update or failed certificate attribute check during an update
        /// check. If the update is not in the "failed" state or the certificate
        /// attribute check has not failed the value is zero.
        ///
        /// TODO: Define typical error codes (for now, see updater/errors.h and the
        /// CERT_ATTR_CHECK_FAILED_* values in nsUpdateService.js)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetErrorCodeAttribute(int aErrorCode);
		
		/// <summary>
        /// The number of patches supplied by this update.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetPatchCountAttribute();
		
		/// <summary>
        /// Retrieves a patch.
        /// @param   index
        /// The index of the patch to retrieve.
        /// @returns The nsIUpdatePatch at the specified index.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUpdatePatch GetPatchAt(uint index);
		
		/// <summary>
        /// Serializes this update object into a DOM Element
        /// @param   updates
        /// The document to serialize into
        /// @returns The DOM Element created by the serialization process
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement Serialize([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument updates);
	}
	
	/// <summary>
    /// An interface describing an object that listens to the progress of an update
    /// check operation. This object is notified as the check continues, finishes
    /// and if it has an error.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8cbceb6e-8e27-46f2-8808-444c6499f836")]
	public interface nsIUpdateCheckListener
	{
		
		/// <summary>
        /// Called every time there is a progress notification loading the Update
        /// Service file.
        /// @param   request
        /// The nsIXMLHttpRequest handling the update check.
        /// @param   position
        /// The current byte downloaded
        /// @param   totalSize
        /// The total number of bytes that have to be downloaded
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnProgress([MarshalAs(UnmanagedType.Interface)] nsIXMLHttpRequest request, uint position, uint totalSize);
		
		/// <summary>
        /// The update check was completed.
        /// @param   request
        /// The nsIXMLHttpRequest handling the update check.
        /// @param   updates
        /// An array of nsIUpdate objects listing available updates.
        /// @param   updateCount
        /// The size of the |updates| array.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnCheckComplete([MarshalAs(UnmanagedType.Interface)] nsIXMLHttpRequest request, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] nsIUpdate[] updates, uint updateCount);
		
		/// <summary>
        /// An error occurred while loading the remote update service file.
        /// @param   request
        /// The nsIXMLHttpRequest handling the update check.
        /// @param   update
        /// A nsIUpdate object that contains details about the
        /// error in its |statusText| property.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnError([MarshalAs(UnmanagedType.Interface)] nsIXMLHttpRequest request, [MarshalAs(UnmanagedType.Interface)] nsIUpdate update);
	}
	
	/// <summary>
    /// An interface describing an object that knows how to check for updates.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("877ace25-8bc5-452a-8586-9c1cf2871994")]
	public interface nsIUpdateChecker
	{
		
		/// <summary>
        /// Checks for available updates, notifying a listener of the results.
        /// @param   listener
        /// An object implementing nsIUpdateCheckListener which is notified
        /// of the results of an update check.
        /// @param   force
        /// Forces the checker to check for updates, regardless of the
        /// current value of the user's update settings. This is used by
        /// any piece of UI that offers the user the imperative option to
        /// check for updates now, regardless of their update settings.
        /// force will not work if the system administrator has locked
        /// the app.update.enabled preference.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CheckForUpdates([MarshalAs(UnmanagedType.Interface)] nsIUpdateCheckListener listener, [MarshalAs(UnmanagedType.U1)] bool force);
		
		/// <summary>
        /// Ends any pending update check.
        /// @param   duration
        /// A value representing the set of checks to stop doing.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StopChecking(ushort duration);
	}
	
	/// <summary>
    /// An interface describing a global application service that handles performing
    /// background update checks and provides utilities for selecting and
    /// downloading update patches.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b5811144-ed30-4343-aff9-c514034aa19a")]
	public interface nsIApplicationUpdateService
	{
		
		/// <summary>
        /// The Update Checker used for background update checking.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUpdateChecker GetBackgroundCheckerAttribute();
		
		/// <summary>
        /// Selects the best update to install from a list of available updates.
        /// @param   updates
        /// An array of updates that are available
        /// @param   updateCount
        /// The length of the |updates| array
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUpdate SelectUpdate([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] nsIUpdate[] updates, uint updateCount);
		
		/// <summary>
        /// Adds a listener that receives progress and state information about the
        /// update that is currently being downloaded, e.g. to update a user
        /// interface.
        /// @param   listener
        /// An object implementing nsIRequestObserver and optionally
        /// nsIProgressEventSink that is to be notified of state and
        /// progress information as the update is downloaded.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddDownloadListener([MarshalAs(UnmanagedType.Interface)] nsIRequestObserver listener);
		
		/// <summary>
        /// Removes a listener that is receiving progress and state information
        /// about the update that is currently being downloaded.
        /// @param   listener
        /// The listener object to remove.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveDownloadListener([MarshalAs(UnmanagedType.Interface)] nsIRequestObserver listener);
		
		/// <summary>
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DownloadUpdate([MarshalAs(UnmanagedType.Interface)] nsIUpdate update, [MarshalAs(UnmanagedType.U1)] bool background, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Pauses the active update download process
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PauseDownload();
		
		/// <summary>
        /// Whether or not there is an download happening at the moment.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsDownloadingAttribute();
		
		/// <summary>
        /// Whether or not the Update Service can check for updates. This is a function
        /// of whether or not application update is disabled by the application and the
        /// platform the application is running on.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCanCheckForUpdatesAttribute();
		
		/// <summary>
        /// Whether or not the Update Service can download and install updates.
        /// This is a function of whether or not the current user has access
        /// privileges to the install directory.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCanApplyUpdatesAttribute();
	}
	
	/// <summary>
    /// An interface describing a global application service that maintains a list
    /// of updates previously performed as well as the current active update.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fede66a9-9f96-4507-a22a-775ee885577e")]
	public interface nsIUpdateManager
	{
		
		/// <summary>
        /// Gets the update at the specified index
        /// @param   index
        /// The index within the updates array
        /// @returns The nsIUpdate object at the specified index
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUpdate GetUpdateAt(int index);
		
		/// <summary>
        /// Gets the total number of updates in the history list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetUpdateCountAttribute();
		
		/// <summary>
        /// The active (current) update. The active update is not in the history list.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUpdate GetActiveUpdateAttribute();
		
		/// <summary>
        /// The active (current) update. The active update is not in the history list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetActiveUpdateAttribute([MarshalAs(UnmanagedType.Interface)] nsIUpdate aActiveUpdate);
		
		/// <summary>
        /// Saves all updates to disk.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SaveUpdates();
	}
	
	/// <summary>
    /// An interface describing an object that can show various kinds of Update
    /// notification UI to the user.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("599fd3c6-ec68-4499-ada5-2997739c97a6")]
	public interface nsIUpdatePrompt
	{
		
		/// <summary>
        /// Shows the application update checking user interface and checks if there
        /// is an update available.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CheckForUpdates();
		
		/// <summary>
        /// Shows the application update available user interface advising that an
        /// update is available for download and install. If the app.update.silent
        /// preference is true or the user interface is already displayed the call will
        /// be a no-op.
        /// @param   update
        /// The nsIUpdate object to be downloaded and installed
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowUpdateAvailable([MarshalAs(UnmanagedType.Interface)] nsIUpdate update);
		
		/// <summary>
        /// Shows the application update downloaded user interface advising that an
        /// update has now been downloaded and a restart is necessary to complete the
        /// update. If background is true (e.g. the download was not user initiated)
        /// and the app.update.silent preference is true the call will be a no-op.
        /// @param   update
        /// The nsIUpdate object that was downloaded
        /// @param   background
        /// Less obtrusive UI, starting with a non-modal notification alert
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowUpdateDownloaded([MarshalAs(UnmanagedType.Interface)] nsIUpdate update, [MarshalAs(UnmanagedType.U1)] bool background);
		
		/// <summary>
        /// Shows the application update installed user interface advising that an
        /// update was installed successfully. If the app.update.silent preference is
        /// true, the app.update.showInstalledUI preference is false, or the user
        /// interface is already displayed the call will be a no-op.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowUpdateInstalled();
		
		/// <summary>
        /// Shows the application update error user interface advising that an error
        /// occurred while checking for or applying an update. If the app.update.silent
        /// preference is true the call will be a no-op.
        /// @param   update
        /// An nsIUpdate object representing the update that could not be
        /// installed. The nsIUpdate object will not be the actual update when
        /// the error occurred during an update check and will instead be an
        /// nsIUpdate object with the error information for the update check.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowUpdateError([MarshalAs(UnmanagedType.Interface)] nsIUpdate update);
		
		/// <summary>
        /// Shows a list of all updates installed to date.
        /// @param   parent
        /// An nsIDOMWindow to set as the parent for this window. Can be null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowUpdateHistory([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow parent);
	}
}
