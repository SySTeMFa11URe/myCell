using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellMenuButton : MonoBehaviour {
    public resourceManager gameManager;
    public Sprite noSelect;
    public Sprite select;
    private SpriteRenderer spRend;
	// Use this for initialization
	void Start () {
        spRend = GetComponent<SpriteRenderer>();
        spRend.sprite = noSelect;
    }
	
	// Update is called once per frame
	void Update () {
        if (gameManager.getMenu() == 1)
        {
            spRend.sprite = select;
        }
        else
        {
            spRend.sprite = noSelect;
        }
	}

    void OnMouseDown()
    {

    }
}
