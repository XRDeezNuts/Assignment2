using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject historyPoint;
    public GameObject historyPoints;

    private int i = 0;
    
    
    // private List<GameObject> historyPoints2 = new(new []
    // {
    //     new GameObject(),
    //     new GameObject(),
    //     new GameObject(),
    //     new GameObject(),
    //     new GameObject()
    // });
    //private HistoryPoint _historyPoint = new HistoryPoint("adsadsads");

    private List<string> lessons = new(new []
    {
        "FIRST ONE",
        "SECOND ONE",
        "THIRD ONE",
        "Fourth ONE"
    });
    //private int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        //HistoryPoint hp = gameObject.GetComponent(typeof(HistoryPoint)) as HistoryPoint;
        // Instantiate(historyPoints2[0], new Vector3(0, 0, 0), Quaternion.identity);
        // Instantiate(historyPoints2[1], new Vector3(1, 0, 0), Quaternion.identity);
        // Instantiate(historyPoints2[2], new Vector3(2, 0, 0), Quaternion.identity);
        // Instantiate(historyPoints2[3], new Vector3(3, 0, 0), Quaternion.identity);
        // Instantiate(historyPoints2[4], new Vector3(4, 0, 0), Quaternion.identity);
        //i++;
        Instantiate(historyPoint, new Vector3(0, 0, 0), Quaternion.identity);
       
    }

    // Update is called once per frame
    void Update()
    {
        if(i == 1)
        Instantiate(historyPoint, new Vector3(1, 0, 0), Quaternion.identity);
        
        if(i == 2)
        Instantiate(historyPoint, new Vector3(2, 0, 0), Quaternion.identity);
        
        if(i == 3)
        Instantiate(historyPoint, new Vector3(3, 0, 0), Quaternion.identity);
        
        if(i == 4)
        Instantiate(historyPoint, new Vector3(4, 0, 0), Quaternion.identity);
    }
}
