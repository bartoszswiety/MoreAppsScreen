using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
    public MoreAppsMaster moreAppsScreen;

    void Start()
    {
        moreAppsScreen = MoreAppsMaster.Init("http://bartoszswiety.com/MoreApps.xml");
    }

    public void ShowMoreApps()
    {

        MoreAppsMaster.SimpleShow("http://bartoszswiety.com/MoreApps.xml");
        //MoreAppsScreen.Show ();
    }
}
