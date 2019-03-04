using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour {

    Coords point = new Coords(10,20);
    Coords startPoint_x = new Coords(-160, 0);
    Coords endPoint_x = new Coords(160, 0);
    Coords startPoint_y = new Coords(0, 100);
    Coords endPoint_y = new Coords(0, -100);
    Coords[] sign =
    {
    new Coords(0,0),
    new Coords(12,75),
    new Coords(15,80),
    new Coords(19,90),
    new Coords(21,78),
    new Coords(33,22),
    new Coords(38,32),
    new Coords(43,45),
    new Coords(54,68),
    new Coords(67,98),
    new Coords (100,100)
    };
    /*
    Coords signStartPoint = new Coords(0, 0);
    Coords signFirstLineEndPoint = new Coords(12, 84);
    Coords signSecondLineEndPoint = new Coords(33, 22);
    Coords signEndLinePoint = new Coords(34, 62); 
    */
    

	// Use this for initialization
	void Start () {
        Debug.Log(point.ToString());
        Coords.DrawLine(startPoint_y, endPoint_y, 0.5f, Color.green);
        Coords.DrawLine(startPoint_x, endPoint_x, 0.5f, Color.red);
        /*  Coords.DrawLine(signStartPoint, signFirstLineEndPoint, 1f, Color.yellow);
          Coords.DrawLine(signStartPoint, signSecondLineEndPoint, 1f, Color.yellow);
          Coords.DrawLine(signFirstLineEndPoint, signEndLinePoint, 1f, Color.magenta);
          Coords.DrawLine(signSecondLineEndPoint, signEndLinePoint, 1f, Color.white);
          */
        foreach (Coords coords in sign)
        {
            Coords.DrawPoint(coords, 2, Color.red);
        }

        Coords.DrawLine(sign[0], sign[1], 0.5f, Color.yellow);
        Coords.DrawLine(sign[0], sign[2], 0.5f, Color.yellow);
        Coords.DrawLine(sign[2], sign[3], 0.5f, Color.magenta);
        Coords.DrawLine(sign[3], sign[4], 0.5f, Color.yellow);
        Coords.DrawLine(sign[0], sign[5], 0.5f, Color.yellow);
        Coords.DrawLine(sign[5], sign[6], 0.5f, Color.blue);
        Coords.DrawLine(sign[6], sign[7], 0.5f, Color.yellow);
        Coords.DrawLine(sign[8], sign[9], 0.5f, Color.magenta);
        Coords.DrawLine(sign[9], sign[10], 0.5f, Color.yellow);
        Coords.DrawLine(sign[4], sign[10], 0.5f, Color.white);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
