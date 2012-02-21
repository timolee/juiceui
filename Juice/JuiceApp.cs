﻿using System;
using System.ComponentModel;
using System.Reflection;
using System.Web.UI;

[assembly: System.Web.PreApplicationStartMethod(typeof(Juice.JuiceApp), "Start")]

namespace Juice {

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class JuiceApp {

		public static void Start() {
			var assembly = Assembly.GetExecutingAssembly();

			ScriptManager.ScriptResourceMapping.AddDefinition("amplify",
					new ScriptResourceDefinition {
						Path = "~/Scripts/amplify.min.js",
						DebugPath = "~/Scripts/amplify.js"
					}
			);

			ScriptManager.ScriptResourceMapping.AddDefinition("jquery",
					new ScriptResourceDefinition {
						Path = "~/Scripts/jquery-1.7.1.min.js",
						DebugPath = "~/Scripts/jquery-1.7.1.js",
						CdnPath = "http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js",
						CdnDebugPath = "http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.js",
						CdnSupportsSecureConnection = true
					}
			);

			ScriptManager.ScriptResourceMapping.AddDefinition("jquery-ui",
					new ScriptResourceDefinition {
						Path = "~/Scripts/jquery-ui-1.8.17.min.js",
						DebugPath = "~/Scripts/jquery-ui-1.8.17.js",
						CdnPath = "http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.17/jquery-ui.min.js",
						CdnDebugPath = "http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.17/jquery-ui.js",
						CdnSupportsSecureConnection = true
					}
			);

			ScriptManager.ScriptResourceMapping.AddDefinition("juice",
					new ScriptResourceDefinition {
						Path = "~/Scripts/juice.min.js",
						DebugPath = "~/Scripts/juice.js"
					}
			);
		}
	}
}