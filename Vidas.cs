using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidas : MonoBehaviour
{
    public GameObject lifes;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color(0f, 1f, 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(lifes.GetComponent<UI_Vidas>().gm.lifes == 10) GetComponent<SpriteRenderer>().color = new Color(0f, 1f, 0f, 1f);
        if (lifes.GetComponent<UI_Vidas>().gm.lifes == 9 && gameObject.tag == "Vida9") GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
        if (lifes.GetComponent<UI_Vidas>().gm.lifes == 8 && gameObject.tag == "Vida8") GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
        if (lifes.GetComponent<UI_Vidas>().gm.lifes == 7 && gameObject.tag == "Vida7") GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
        if (lifes.GetComponent<UI_Vidas>().gm.lifes == 6 && gameObject.tag == "Vida6") GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
        if (lifes.GetComponent<UI_Vidas>().gm.lifes == 5 && gameObject.tag == "Vida5") GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
        if (lifes.GetComponent<UI_Vidas>().gm.lifes == 4 && gameObject.tag == "Vida4") GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
        if (lifes.GetComponent<UI_Vidas>().gm.lifes == 3 && gameObject.tag == "Vida3") GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
        if (lifes.GetComponent<UI_Vidas>().gm.lifes == 2 && gameObject.tag == "Vida2") GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
        if (lifes.GetComponent<UI_Vidas>().gm.lifes == 1 && gameObject.tag == "Vida1") GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
        if (lifes.GetComponent<UI_Vidas>().gm.lifes == 0 && gameObject.tag == "Vida") GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
    }

}
