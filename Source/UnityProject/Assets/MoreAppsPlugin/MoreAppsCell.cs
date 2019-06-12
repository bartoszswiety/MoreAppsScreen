using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoreAppsCell : MonoBehaviour 
{
	public int id;
	public RawImage iconImage;
	public Text nameText;
	public RectTransform rect;
	public string url;
	public float y;
	public float yy;
	public float x;
	public float xx;
	public void Click()
	{
		Application.OpenURL (url);
	}

	void Start()
	{
	//	y = (id + 1) * -(Screen.width/2);
	//	yy = id * -(Screen.width/2);

	}

	void Update()
	{

		rect.offsetMin = new Vector2(x,y);
		rect.offsetMax = new Vector2(xx,yy);
	}
}
