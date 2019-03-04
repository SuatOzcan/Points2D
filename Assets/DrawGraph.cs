using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGraph : MonoBehaviour {
    public int size = 20;
    public int xmax = 200;
    public int ymax = 200;

    Coords startPoint_x;
    Coords endPoint_x;
    Coords startPoint_y;
    Coords endPoint_y;

    // Use this for initialization
    void Start () {

        startPoint_x = new Coords(xmax, 0);
        endPoint_x = new Coords(-xmax, 0);
        startPoint_y = new Coords(0,ymax);
        endPoint_y = new Coords(0, -ymax);

        Coords.DrawLine(startPoint_y, endPoint_y, 1f, Color.green);
        Coords.DrawLine(startPoint_x, endPoint_x, 1f, Color.red);

        int xoffset = (int)(xmax / (float)size);       

        for (int  x = -xoffset*size;  x <= xoffset*size;  x+=size)
        {
            Coords.DrawLine(new Coords(x,-ymax), new Coords(x,ymax), 0.5f, Color.white);
        }

        int yoffset = (int)(ymax / (float)size);
        for (int y = -yoffset*size; y <= yoffset*size; y+=size)
        {
            Coords.DrawLine(new Coords(-xmax,y), new Coords(xmax,y), 0.5f, Color.white);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
