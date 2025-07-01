using UnityEngine;
using System.Collections;

public class MapDisplay : MonoBehaviour
{

    public Renderer textureRender;

    // Draws the noise map as a texture.
    public void DrawNoiseMap(float[,] noiseMap)
    {
        int width = noiseMap.GetLength(0);
        int height = noiseMap.GetLength(1);

        // Create a new texture to apply the noise map to.
        Texture2D texture = new Texture2D(width, height);

        // Create an array to hold the colors of the texture.
        Color[] colourMap = new Color[width * height];
        // Loop through each pixel of the map.
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                // Interpolate between black and white based on the noise value.
                colourMap[y * width + x] = Color.Lerp(Color.black, Color.white, noiseMap[x, y]);
            }
        }
        // Apply the color map to the texture.
        texture.SetPixels(colourMap);
        texture.Apply();

        // Apply the texture to the material of the renderer.
        textureRender.sharedMaterial.mainTexture = texture;
        // Scale the renderer to match the map dimensions.
        textureRender.transform.localScale = new Vector3(width, 1, height);
    }
}