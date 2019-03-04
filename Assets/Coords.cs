using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coords : MonoBehaviour {

    float x;
    float y;
    float z;

    public Coords(float _X, float _Y)
    {
        x = _X;
        y = _Y;
        z = -1;
    }

    public override string ToString()
    {
        return "("+x+","+y+","+z+")";
    }

    public static void DrawPoint(Coords position,float width, Color colour)
    {
        GameObject line = new GameObject("Point_" + position.ToString());
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = colour;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, new Vector3(position.x - width / 3f, position.y - width / 3f, position.z));
        lineRenderer.SetPosition(1, new Vector3(position.x + width / 3f, position.y + width, position.z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;

    }

    internal static void DrawLine(Coords startPos, Coords endpos, float width, Color colour)
    {
        GameObject line = new GameObject("Line starts from_" + startPos.ToString() + "ends on" + endpos.ToString());
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = colour;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, new Vector3(startPos.x  , startPos.y  , startPos.z));
        lineRenderer.SetPosition(1, new Vector3(endpos.x  , endpos.y  , endpos.z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }
}
