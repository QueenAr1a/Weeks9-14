using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class dropdowndem : MonoBehaviour
{
    public GameObject Panel;
    public TextMeshProUGUI congrats;
        public TextMeshProUGUI failed;
    public TMP_Dropdown dropdowncut;
    public SpriteRenderer cutlery;
    public TMP_Dropdown dropdowntab;
    public SpriteRenderer Table;
    public SpriteRenderer ingred;
    public TMP_Dropdown dropdowning;
    private int cutscore;
    public SpriteRenderer broth;
    public TMP_Dropdown dropdownbro;
    int tabscore;
    int ingscore;
    int broscore;
    // Start is called before the first frame update
    void Start()
    {
        cutlery.sprite = dropdowncut.options[0].image;
        Table.sprite = dropdowntab.options[0].image;
        ingred.sprite = dropdowning.options[0].image;
      
        broth.sprite = dropdownbro.options[0].image;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CutChange(int index)

    {
        cutlery.sprite = dropdowncut.options[index].image;
        if (index == 1)
        {
            Vector3 cutchange = cutlery.transform.localScale;
            cutchange.x = 0.5f;
            cutchange.y = 0.5f;
            cutchange.z = 0.5f;
            Vector3 cutrot = cutlery.transform.eulerAngles;
            cutrot.x = 1;
            cutrot.y = 1;
            cutrot.z = 1f;
            cutlery.transform.localScale = cutchange;
            cutlery.transform.eulerAngles = cutrot;
            cutscore = index;
            Debug.Log(cutscore);

        }
        if (index == 2)
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
            cutscore = index;
            Debug.Log(cutscore);

        }
        if (index == 0)
        {
      
            cutscore = index;
            Debug.Log(cutscore);
        }
    }

    public void TableChange(int indextab)

    {
        Table.sprite = dropdowntab.options[indextab].image;
        if (indextab == 1)
        {
            Vector3 tabchange = Table.transform.localScale;
            tabchange.x = 0.5f;
            tabchange.y = 0.5f;
            tabchange.z = 0.5f;
            Vector3 tabrot = Table.transform.localScale;
           
            Table.transform.localScale = tabchange;
           
            tabscore = 1;

        }
        if (indextab == 2)
        {
            Vector3 tabchange = Table.transform.localScale;
            tabchange.x = 0.25f;
            tabchange.y = 0.25f;
            tabchange.z = 0.25f;
            Vector3 tabrot = Table.transform.eulerAngles;
            Table.transform.localScale = tabchange;
            
            tabscore = 2;

        }
        if (indextab == 0)
        {

            tabscore = 0;

        }


    }

    public void Ingredients(int indexing)

    {
        ingred.sprite = dropdowning.options[indexing].image;
        if (indexing == 1)
        {
  

            ingscore = 1;

        }
        if (indexing == 2)
        {
         

            ingscore = 2;

        }
        if (indexing == 0)
        {

            ingscore = 0;

        }
    }
    public void Broth(int indexbro)

    {
        broth.sprite = dropdownbro.options[indexbro].image;
        if (indexbro == 1)
        {


            broscore = 1;

        }
        if (indexbro == 2)
        {


            broscore = 2;

        }
        if (indexbro == 0)
        {

            broscore = 0;

        }
    }

    public void panel()
    {
        Panel.SetActive(true);
        if ( broscore == 1 && ingscore == 1 && tabscore == 2 && cutscore == 2 )
        {
     
        }
    }

}

