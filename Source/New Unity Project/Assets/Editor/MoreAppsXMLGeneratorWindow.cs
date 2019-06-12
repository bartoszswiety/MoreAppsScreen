using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class MoreAppsXMLGeneratorWindow :EditorWindow
{
	string header = "Hello World";
	public static int picturesCount = 0;
	Texture2D[] appIcons = new Texture2D[0];
	string[] url;
	string[] name;

	public Texture2D texturePlaceHolder;
	[MenuItem ("MoreApps/Generate XML")]
	static void Init () {
		// Get existing open window or if none, make a new one:
		MoreAppsXMLGeneratorWindow window = (MoreAppsXMLGeneratorWindow)EditorWindow.GetWindow (typeof (MoreAppsXMLGeneratorWindow));
		window.Show();
		picturesCount = 0;
	}


	void OnGUI () {
		GUILayout.Label ("Generate MoreApps XML", EditorStyles.boldLabel);
		header = EditorGUILayout.TextField ("Heder Text", header);

		if (GUILayout.Button ("Add App")) 
		{
			AppendArrays();
			picturesCount++;



		}
		if (GUILayout.Button ("Generate")) 
		{
			MoreAppsXMLGenerator.GenerateXML(this.appIcons,this.url,this.name,header);
			
		}

		for (int i = 0; i < appIcons.Length; i++) 
		{
			EditorGUI.LabelField(new Rect(0,(200*(i)) + 100,100,50),"App " + i.ToString() + " Name");
			EditorGUI.LabelField(new Rect(0,(200*(i)) + 120,100,50),"URL");

			name[i] = EditorGUI.TextField(new Rect(100,(200*(i) + 100),256,20),name[i]);
			url[i] = EditorGUI.TextField(new Rect(100,(200*(i) + 120),256,20),url[i]);
			appIcons[i] = EditorGUI.ObjectField(new Rect(0,200*(i) + 160,256,256),"Icon", appIcons[i] ,typeof(Texture2D)) as Texture2D;
		}
	
	}


	void AppendArrays()
	{
		Texture2D[] icons = appIcons;
		string[] urls = url;
		string[] names = name;
	
		appIcons = new Texture2D[picturesCount + 1];
		url = new string[picturesCount + 1];
		name = new string[picturesCount + 1];


		for (int i = 0; i < icons.Length; i++) 
		{
			appIcons[i] = icons[i];
			url[i]= urls[i];
			name[i]= names[i];
		}

	}

}
