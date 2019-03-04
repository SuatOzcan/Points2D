using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGraph : MonoBehaviour {
    public int size = 20;
    Coords startPoint_x = new Coords(-160, 0);
    Coords endPoint_x = new Coords(160, 0);
    Coords startPoint_y = new Coords(0, 100);
    Coords endPoint_y = new Coords(0, -100);

    // Use this for initialization
    void Start () {
        Coords.DrawLine(startPoint_y, endPoint_y, 1f, Color.green);
        Coords.DrawLine(startPoint_x, endPoint_x, 1f, Color.red);

        for (int  x = -160;  x <= 160;  x+=size)
        {
            Coords.DrawLine(new Coords(x,-100), new Coords(x,100), 0.5f, Color.white);
        }
        for (int y = -100; y <= 100; y+=size)
        {
            Coords.DrawLine(new Coords(-160,y), new Coords(160,y), 0.5f, Color.white);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
