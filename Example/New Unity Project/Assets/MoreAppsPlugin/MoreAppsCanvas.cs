using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class MoreAppsCanvas : MonoBehaviour 
{
	public RectTransform panel;
	public RectTransform cellsPanel;
	public Text headerText;

	public List<MoreAppsCell> cells;
	public bool show = false;

	private float starty;
	public float maxY;
	private float y;
	private float lastY;
	private float delta;

	void Start()
	{
		starty =55;
		y = starty;
		maxY = starty;
	}


	public void Show()
	{
		show = true;
		gameObject.SetActive (true);
	}

	public void Hide()
	{
		show = false;
	}

	void Update()
	{
		if (show) 
		{
			panel.localScale = Vector3.Lerp (panel.localScale, Vector3.one, 10 * Time.deltaTime);

			if (Input.GetMouseButtonDown (0)) 
			{
				delta = Input.mousePosition.y;
			}
			if (Input.GetMouseButton (0)) 
			{
				y -= (Input.mousePosition.y - delta);
				delta = Input.mousePosition.y;
			}
			if (Input.GetMouseButtonUp (0))
			{
				if (y < starty)
					y = starty;

				if(y > starty + (cells.Count * Screen.width/2))
					y = maxY;
			}
			if(Input.touchCount > 0)
			{
				y += Input.GetTouch(0).deltaPosition.y;
			}
			else
			{
				if(y < starty)
					y = starty;
				}
					if(y > starty + (cells.Count * Screen.width/2))
						y = maxY;
			
		
			cellsPanel.anchoredPosition = Vector2.Lerp(cellsPanel.anchoredPosition, new Vector2(cellsPanel.anchoredPosition.x, y), 10 * Time.deltaTime);
		}
		else 
		{
			panel.localScale = Vector3.Lerp (panel.localScale, Vector3.zero, 10 * Time.deltaTime);
			if(panel.localScale.y < 0.01F)
				gameObject.SetActive(false);
		}
	}


}
