using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour
{

    public int mapWidth;
    public int mapHeight;
    public float noiseScale;

    public bool autoUpdate;

    // Generates the map.
    public void GenerateMap()
    {
        // Generate the noise map.
        float[,] noiseMap = Noise.GenerateNoiseMap(mapWidth, mapHeight, noiseScale);

        // Find the MapDisplay object in the scene and draw the noise map.
        MapDisplay display = FindFirstObjectByType<MapDisplay>();
        display.DrawNoiseMap(noiseMap);
    }
}

