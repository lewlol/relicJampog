using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGen : MonoBehaviour
{
    public GameObject[] tile;
    private GameObject currentTile;
    public int width = 10;
    public int height = 10;

    void Start()
    {
        GenerateTile();
    }

    private void GenerateTile()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                currentTile = tile[Random.Range(0, tile.Length)];
                Instantiate(currentTile, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }
}
