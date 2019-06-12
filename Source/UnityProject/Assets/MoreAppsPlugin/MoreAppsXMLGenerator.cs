using UnityEngine;
using System.Collections;

public class MoreAppsXMLGenerator
{
	public static void GenerateXML( Texture2D[] icons, string[] urls,string[] name, string header)
	{
		Debug.Log ("Generating XML");
	MoreAppsContainer container = new MoreAppsContainer ();
		container.Apps = new AppContainer[icons.Length];
		container.Header = header;
		for (int i = 0; i < urls.Length; i++) 
		{
			AppContainer app = new AppContainer ();
			app.Name = name[i];
			app.href = urls[i];
			app.imageByte = icons[i].EncodeToPNG();
			container.Apps[i] = app;
		}
		container.Save (Application.dataPath + "/MoreApps.xml");

		Debug.Log ("XML Generated : " + Application.dataPath + "/MoreApps.xml");
	}
}
