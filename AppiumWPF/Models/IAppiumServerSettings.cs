﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Appium.Models
{
	public interface IAppiumServerSettings
	{
		#region Core Server Settings Properties
				
		/// <summary>path to the application</summary>
		string ApplicationPath { get; set; }

		/// <summary>android activity</summary>
		string AndroidActivity { get; set; }

		/// <summary>android activity</summary>
		uint AndroidDeviceReadyTimeout { get; set; }

		/// <summary>android package</summary>
		string AndroidPackage { get; set; }

		/// <summary>android activity to wait for</summary>
		string AndroidWaitActivity { get; set; }

		/// <summary>avd to launch</summary>
		string AVDToLaunch { get; set; }

		/// <summary>ip address to listen on</summary>
		string IPAddress { get; set; }

		/// <summary>true if an AVD will be launched</summary>
		bool LaunchAVD { get; set; }

		/// <summary>true if a full android reset will be performed</summary>
		bool PerformFullAndroidReset { get; set; }

		/// <summary>port to listen on</summary>
		uint Port { get; set; }

		/// <summary>true if an android activity is supplied</summary>
		bool UseAndroidActivity { get; set; }

		/// <summary>true if the android device ready timeout will be used</summary>
		bool UseAndroidDeviceReadyTimeout { get; set; }

		/// <summary>true if an android package is supplied</summary>
		bool UseAndroidPackage { get; set; }

		/// <summary>true if an android wait activity is supplied</summary>
		bool UseAndroidWaitActivity { get; set; }

		/// <summary>true if an application path will be used</summary>
		bool UseApplicationPath { get; set; }

		/// <summary>true if a remote server will be used</summary>
		bool UseRemoteServer { get; set; }

		#endregion
		
		#region Preferences Properties

		/// <summary>true if the nodejs debugger will break on application start</summary>
		bool BreakOnApplicationStart { get; set; }

		/// <summary>true if appium should check for updates</summary>
		bool CheckForUpdates { get; set; }

		/// <summary>path to external node.exe</summary>
		string ExternalNodeJSBinary { get; set; }

		/// <summary>pack to external appium node js package</summary>
		string ExternalAppiumPackage { get; set; }

		/// <summary>true if artifacts will be kept after a session</summary>
		bool KeepArtifacts { get; set; }

		/// <summary>port on which the nodejs debugger will run</summary>
		uint NodeJSDebugPort { get; set; }

		/// <summary>true if appium should prelaunch the application</summary>
		bool PrelaunchApplication { get; set; }

		/// <summary>true if quiet logging should be used</summary>
		bool QuietLogging { get; set; }

		/// <summary>true if application state should be reset between sessions</summary>
		bool ResetApplicationState { get; set; }

		/// <summary>true if developer mode is enabled</summary>
		bool UseDeveloperMode { get; set; }

		/// <summary>true if an external node js binary will be used</summary>
		bool UseExternalNodeJSBinary { get; set; }

		/// <summary>true if an external appium package will be used</summary>
		bool UseExternalAppiumPackage { get; set; }

		/// <summary>true if nodejs debugging will be used</summary>
		bool UseNodeJSDebugging { get; set; }

		#endregion

		/// <summary>
		/// Saves settings to underlying data store
		/// </summary>
		void Save();

		/// <summary>
		/// Loads settings from underlying data store
		/// </summary>
		void Load();
	}
}
