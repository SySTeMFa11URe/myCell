using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resourceManager : MonoBehaviour {
    public int defaultMenu = 1;
    private int menu;
	// Use this for initialization
	void Start () {
        menu = defaultMenu;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public int getMenu()
    {
        return menu;
    }

    public void setMenu(int menuToSet)
    {
        menu = menuToSet;
    }
}
