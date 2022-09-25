using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;


public class PlaceObject : MonoBehaviour
{
    [SerializeField]
     ARRaycastManager m_RaycastManager;
    
    List<ARRaycastHit> m_hits = new List<ARRaycastHit>();

    [SerializeField]
    GameObject spawnablePrefab;
    [SerializeField]
    GameObject spawnablePrefab2;
    [SerializeField]
    GameObject spawnablePrefab3;
    [SerializeField]
    GameObject spawnablePrefab4;

    Camera arCam;
    GameObject spawnedObject;
    int clickCount;
    List<GameObject> arr;


    // Start is called before the first frame update
    void Start()
    {
        spawnedObject = null;
        arCam = GameObject.Find("AR Camera").GetComponent<Camera>();
        clickCount = 0;

        arr = new List<GameObject>(new []{
            spawnablePrefab, spawnablePrefab2, spawnablePrefab3, spawnablePrefab4
        });
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.touchCount == 0) return;

       RaycastHit hit;
       Ray ray = arCam.ScreenPointToRay(Input.GetTouch(0).position);

       if (m_RaycastManager.Raycast(Input.GetTouch(0).position, m_hits)){
        if (Input.GetTouch(0).phase == TouchPhase.Began && spawnedObject == null){
            if (Physics.Raycast(ray, out hit)){
                if (hit.collider.gameObject.tag == "Spawnable"){
                    spawnedObject = hit.collider.gameObject;
                }
                else
                {
                    SpawnablePrefab(m_hits[0].pose.position);
                }
            }
        }
        else if(Input.GetTouch(0).phase == TouchPhase.Moved && spawnedObject == null){
            spawnedObject.transform.position = m_hits[0].pose.position;
        }
        if (Input.GetTouch(0).phase == TouchPhase.Ended){
            spawnedObject = null;
        }
       } 
    }

    private void SpawnablePrefab(Vector3 spawnPostion){
        if(clickCount > arr.Count - 1){
            clickCount = 0;
        } else {
            clickCount++;
        }
        spawnedObject = Instantiate(arr[clickCount], spawnPostion, Quaternion.identity);
    }
}
