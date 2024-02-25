using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ProgramManager : MonoBehaviour
{

    public GameObject planePrefab;
    public ARRaycastManager arRayCastManager;
    // Start is called before the first frame update
    void Start()
    {
        arRayCastManager = FindObjectOfType<ARRaycastManager>();

        planePrefab.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        MarkerCreate();
    }

    public void MarkerCreate()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        arRayCastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);
        planePrefab.transform.position = hits[0].pose.position;
        
        if(hits.Count > 0)
        {
            planePrefab.SetActive(true);
        }
    }
}
