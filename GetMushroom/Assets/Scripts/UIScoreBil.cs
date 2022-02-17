using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreBil : MonoBehaviour
{
    public Text North;
    public Text East;
    public Text South;
    public Text West;

    public Transform NorthTrans;
    public Transform SouthTrans;
    public Transform WestTrans;
    public Transform EastTrans;

    public Vector2 Offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPos = Camera.main.WorldToScreenPoint(NorthTrans.position);
        North.rectTransform.position = screenPos + Offset;

        screenPos = Camera.main.WorldToScreenPoint(SouthTrans.position);
        South.rectTransform.position = screenPos + Offset;

        screenPos = Camera.main.WorldToScreenPoint(EastTrans.position );
        East.rectTransform.position = screenPos + Offset;

        screenPos = Camera.main.WorldToScreenPoint(WestTrans.position);
        West.rectTransform.position = screenPos + Offset;
    }

    public void UpdateScore(int north, int east, int south, int west)
    {
        South.text = "+" + south;
        North.text = "+" + north;
        West.text = "+" + west;
        East.text = "+" + east;
        if(north > 0)
        {
            StartCoroutine(NorthAdd());
        }
        if(south > 0)
        {
            StartCoroutine(SouthAdd());
        }
        if(west > 0)
        {
            StartCoroutine(WestAdd());
        }
        if(east > 0)
        {
            StartCoroutine(EastAdd());
        }
    }

    IEnumerator NorthAdd()
    {
        North.enabled = true;
        yield return new WaitForSeconds(1.5f);
        North.enabled = false;
    }

    IEnumerator SouthAdd()
    {
        South.enabled = true;
        yield return new WaitForSeconds(1.5f);
        South.enabled = false;
    }

    IEnumerator WestAdd()
    {
        West.enabled = true;
        yield return new WaitForSeconds(1.5f);
        West.enabled = false;
    }

    IEnumerator EastAdd()
    {
        East.enabled = true;
        yield return new WaitForSeconds(1.5f);
        East.enabled = false;
    }
}
