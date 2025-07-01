using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(MapGenerator))]
public class MapGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // Get a reference to the MapGenerator component.
        MapGenerator mapGen = (MapGenerator)target;

        // If any value in the inspector changes and autoUpdate is on, generate the map.
        if (DrawDefaultInspector())
        {
            if (mapGen.autoUpdate)
            {
                mapGen.GenerateMap();
            }
        }

        // Add a button to the inspector to manually generate the map.
        if (GUILayout.Button("Generate"))
        {
            mapGen.GenerateMap();
        }
    }
}

