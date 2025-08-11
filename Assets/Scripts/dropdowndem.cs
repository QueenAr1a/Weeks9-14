using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class dropdowndem : MonoBehaviour
{


    public TMP_Dropdown dropdowncut;
    public SpriteRenderer cutlery;
    public TMP_Dropdown dropdowntab;
    public SpriteRenderer Table;
    private int cutscore;
    int tabscore;
    // Start is called before the first frame update
    void Start()
    {
        cutlery.sprite = dropdowncut.options[0].image;
        Table.sprite = dropdowntab.options[0].image;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CutChange(int index)

    {
        cutlery.sprite = dropdowncut.options[index].image;
        if (dropdowncut.options[1].image == true)
        {
            Vector3 cutchange = cutlery.transform.localScale;
            cutchange.x = 0.5f;
            cutchange.y = 0.5f;
            cutchange.z = 0.5f;
            Vector3 cutrot = cutlery.transform.eulerAngles;
            cutrot.z = 1f;
            cutlery.transform.localScale = cutchange;
            cutlery.transform.localScale = cutrot;
            cutscore = 1;

        }
        if (dropdowncut.options[2].image == true)
        {
            Vector3 cutchange = cutlery.transform.localScale;
            cutchange.x = 0.25f;
            cutchange.y = 0.25f;
            cutchange.z = 0.25f;
            Vector3 cutrot = cutlery.transform.eulerAngles;
            cutrot.x = 1;
            cutrot.y = 1;
            cutrot.z = 27f;
            cutlery.transform.localScale = cutchange;
            cutlery.transform.eulerAngles = cutrot;
            cutscore = 2;

        }
        if (dropdowncut.options[0].image == true)
        {
      
            cutscore = 0;

        }
    }

    public void TableChange(int index)

    {
        Table.sprite = dropdowntab.options[index].image;
        if (dropdowntab.options[1].image)
        {
            Vector3 tabchange = Table.transform.localScale;
            tabchange.x = 0.5f;
            tabchange.y = 0.5f;
            tabchange.z = 0.5f;
            Vector3 tabrot = Table.transform.localScale;
           
            Table.transform.localScale = tabchange;
           
            tabscore = 1;

        }
        if (dropdowntab.options[2].image)
        {
            Vector3 tabchange = Table.transform.localScale;
            tabchange.x = 0.25f;
            tabchange.y = 0.25f;
            tabchange.z = 0.25f;
            Vector3 tabrot = Table.transform.localScale;
            Table.transform.localScale = tabchange;
            
            tabscore = 2;

        }
        if (dropdowntab.options[0].image)
        {

            tabscore = 0;

        }
    }


}

