using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class MoreAppsMaster : MonoBehaviour
{
    public string url = "";
    public MoreAppsContainer container;
    public MoreAppsCanvas canvas;
    public bool showAfterLoad;
    public static MoreAppsMaster Instance;
    [HideInInspector]
    public static MoreAppsMaster Init(string xmlURL)
    {
        GameObject go = new GameObject();
        MoreAppsMaster master = go.AddComponent<MoreAppsMaster>();
        master.url = xmlURL;
        master.gameObject.name = "MoreApps";
        return master;
    }

    public static void SimpleShow(string xmlURL)
    {
        if (MoreAppsMaster.Instance == null)
        {
            GameObject go = new GameObject();
            MoreAppsMaster master = go.AddComponent<MoreAppsMaster>();
            master.url = xmlURL;
            master.gameObject.name = "MoreApps";
            master.showAfterLoad = true;
            MoreAppsMaster.Instance = master;
        }
        else
            MoreAppsMaster.Instance.Show();
    }

    void Start()
    {
        //DEBUG_INIT ();
        LoadXMLData();
    }

    private void DEBUG_INIT()
    {
        MoreAppsContainer container = new MoreAppsContainer();
        AppContainer app = new AppContainer();
        app.Name = "hello world";
        //app.imageByte = text.EncodeToPNG ();
        app.href = "http://bartoszswiety.com";
        container.Apps = new AppContainer[2];
        container.Apps[0] = app;
        app.Name = "chuj";
        container.Apps[1] = app;
        container.Save(Application.dataPath + "/MoreApps.xml");
    }


    private void SetCloudData(string data)
    {
        print(data);
        if (data != "")
        {
            string output = data;//File.ReadAllText(Application.dataPath + "/Hello.xml");
            container = MoreAppsContainer.LoadFromText(output);
            container.Proceed();
            //Debug.Log (container.Apps [0].name);
            CreateCanvas();
        }
        else
            Debug.LogError("Error with loading File");
    }

    void LoadXMLData()
    {
        if (Application.internetReachability != NetworkReachability.NotReachable)
            StartCoroutine(DownloadCloudData());
        else
            SetCloudData(File.ReadAllText(Application.dataPath + "/MoreApps.xml"));
    }


    IEnumerator DownloadCloudData()
    {
        WWW www = new WWW(url);
        yield return www;
        if (www.text != "")
        {
            SetCloudData(www.text);
            File.WriteAllText(Application.dataPath + "/MoreApps.xml", www.text);
        }
        else
            Debug.LogError("Error 54");
    }

    public void Show()
    {
        if (canvas != null)
        {
            canvas.show = true;
            canvas.gameObject.SetActive(true);
        }
    }

    public void Hide()
    {
        canvas.show = false;
    }

    private void CreateCanvas()
    {
        canvas = (Instantiate(Resources.Load("MoreAppsCanvas", typeof(GameObject)) as GameObject)).GetComponent<MoreAppsCanvas>();
        Object cellOBJ = Resources.Load("MoreAppsAppCell", typeof(GameObject));
        bool left = true;
        int line = 0;
        canvas.headerText.text = container.Header;
        for (int i = 0; i < 1; i++)
        {
            foreach (AppContainer app in container.Apps)
            {
                MoreAppsCell cell = (Instantiate(cellOBJ, Vector3.zero, Quaternion.identity) as GameObject).GetComponent<MoreAppsCell>();
                cell.rect.parent = canvas.cellsPanel;
                cell.nameText.text = app.Name;
                cell.iconImage.texture = app.image;
                cell.rect.localScale = new Vector3(1, 1, 1);
                cell.url = app.href;
                cell.id = canvas.cells.Count;

                cell.y = (line + 1) * -(Screen.width / 2);
                cell.yy = line * -(Screen.width / 2);

                if (left)
                {
                    cell.x = 0;
                    cell.xx = Screen.width / 2;
                    left = false;
                }
                else
                {
                    cell.x = Screen.width / 2;
                    cell.xx = Screen.width;
                    line++;
                    left = true;
                }
                canvas.cells.Add(cell);
            }
        }
        if (canvas.cells.Count > Screen.height / 250)
            canvas.maxY = (canvas.cells.Count - 3) * 250;

        if (showAfterLoad)
            canvas.show = true;
    }

}
[System.Serializable]
[XmlRoot("MoreAppsContainer")]
public class MoreAppsContainer
{
    [XmlArray("Apps"), XmlArrayItem("AppContainer")]
    public AppContainer[] Apps;
    [XmlElement("Header")]
    public string Header;

    public void Save(string path)
    {
        var serializer = new XmlSerializer(typeof(MoreAppsContainer));
        using (var stream = new FileStream(path, FileMode.Create))
        {
            serializer.Serialize(stream, this);
        }
        Debug.Log("save " + path);
    }

    public static MoreAppsContainer LoadFromText(string text)
    {
        var serializer = new XmlSerializer(typeof(MoreAppsContainer));
        return serializer.Deserialize(new StringReader(text)) as MoreAppsContainer;
    }

    public void Proceed()
    {
        foreach (AppContainer app in Apps)
        {
            app.CreateImage();
        }
    }
}
[System.Serializable]
public class AppContainer
{
    [XmlAttribute("name")]
    public string Name;
    public byte[] imageByte;
    [XmlIgnore]
    public Texture2D image;
    public string href;

    public void CreateImage()
    {
        image = new Texture2D(256, 256);
        image.LoadImage(imageByte);
        imageByte = null;
    }


}
