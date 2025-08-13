using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using Cinemachine;
public class Tileswapper : MonoBehaviour
{
    //When we click, we're going to paint onto the tilemap
    public Tilemap drawingTilemap;

    public Tile grassTile, rockTile;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldMousePosition.z = 0f;
            Vector3Int tileIndex = drawingTilemap.WorldToCell(worldMousePosition);

            Tile selectedTile = (Tile)drawingTilemap.GetTile(tileIndex);
            
            //Check what visual is mapped on this tile

            if (selectedTile == grassTile)
            {
                drawingTilemap.SetTile(tileIndex, rockTile);
            }
            else
            {
                drawingTilemap.SetTile(tileIndex, grassTile);
            }

            //Based on that visual, we will update the visual to be something else

            Debug.Log("Selected tile index[" + tileIndex.ToString() + "]");
        }
    }
}
