using UnityEngine;
using System.Collections;

public static class Noise
{

    // Generates a 2D float array representing a noise map.
    public static float[,] GenerateNoiseMap(int mapWidth, int mapHeight, float scale)
    {
        // Create a 2D float array to store the noise values.
        float[,] noiseMap = new float[mapWidth, mapHeight];

        // Ensure the scale is not zero to avoid division by zero errors.
        if (scale <= 0)
        {
            scale = 0.0001f;
        }

        // Loop through each pixel of the map.
        for (int y = 0; y < mapHeight; y++)
        {
            for (int x = 0; x < mapWidth; x++)
            {
                // Calculate the sample coordinates based on the scale.
                float sampleX = x / scale;
                float sampleY = y / scale;

                // Generate a Perlin noise value for the coordinates.
                float perlinValue = Mathf.PerlinNoise(sampleX, sampleY);
                // Store the noise value in the map.
                noiseMap[x, y] = perlinValue;
            }
        }

        return noiseMap;
    }
}
