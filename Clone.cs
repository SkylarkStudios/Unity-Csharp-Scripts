using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour {
    [SerializeField] private int x = 0;
    [SerializeField] private int y = 0;
    [SerializeField] private int z = 0;
    [SerializeField] private float timer = 30f;
    Vector3 pos = new Vector3(0, 0, 0);
    private bool notClone = true;
    public GameObject clone;
    float timertime;
    public GameObject prefab;
    float clonenum;
    // Use this for initialization
    void Start () {
        pos = new Vector3(x,y,z);
        timertime = timer;
        clonenum = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (notClone)
        {
            CloneTimer();
            Debug.Log(clonenum);
        }
	}
    void CloneTimer() {
        timertime -= Time.deltaTime;
        if (timertime <= 0) {
            CreateClone();
            timertime = timer;
            clonenum++;
            
        }
    }
    void CreateClone()
    {
        clone = Instantiate(prefab, pos, Quaternion.identity);
        clone.GetComponent<Clone>().notClone = false;
    }
}
