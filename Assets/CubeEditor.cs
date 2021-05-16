using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
[SelectionBase]
public class CubeEditor : MonoBehaviour
{
    Waypoint waypoint;

    private void Awake()
    {
        waypoint = GetComponent<Waypoint>();
    }

    void Update()
    {
        SnapToGrid();
        UpdateLabel();

    }

    private void SnapToGrid()
    {
        int gridSize = waypoint.GetGridSize();
        transform.position = new Vector3(
            waypoint.GetGridPos().x,
            0f,
            waypoint.GetGridPos().y     // waypoint is a 2d Vector so the 2nd parameter is the z
        );                              // in the 3d world, but it's y in our 2d vector
    }

    private void UpdateLabel()
    {
        TextMesh textMesh = GetComponentInChildren<TextMesh>();
        int gridSize = waypoint.GetGridSize();
        string labelText = transform.position.x / 10 + "," + transform.position.z / 10; // le prof a fait : waypoint.GetGridPos().x au lieu de transform.position.x
        textMesh.text = labelText;
        gameObject.name = labelText;
    }
}
