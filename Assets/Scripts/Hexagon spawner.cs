using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hexagonspawner : MonoBehaviour
{
    public GameObject hexagonPrefab;
    public Button hexagonColourizerButton;
    public Hexagoncounter hexagonCounter;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnSpawnClick()
    {
        Vector3 spawnPosition = transform.position + (Vector3)Random.insideUnitCircle * 5;

        //Spawned a new hexagon (when we clicked the button)
        GameObject spawnedHexagonObject = Instantiate(hexagonPrefab, spawnPosition, Quaternion.identity);
        //Get access to its hexagon script
        Hexagon spawnedHexagon = spawnedHexagonObject.GetComponent<Hexagon>();

        //spawnedHexagon.onColourChange is the event of this specific spawned hexagon

        //We are adding a new listener which will do something every time the colour
        //of this hexagon changes for whatever reason

        //The listener is the HexagonCounter (which manages the text of the count)
        //And the method is going to increase the count every time we change the colour
        //of this hexagon.
        spawnedHexagon.onColourChange.AddListener(hexagonCounter.IncreaseCount);





        hexagonColourizerButton.onClick.AddListener(spawnedHexagon.OnColourizeClick);
    }

}
