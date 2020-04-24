using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    public GameObject enemy;

    public int CurHp = 30;
    // Start is called before the first frame update
    public void Dmg(int DMGcount)
    {
        CurHp-= DMGcount;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<RectTransform>().position = Camera.main.WorldToScreenPoint(enemy.transform.position);
        GetComponent<Text>().text = CurHp.ToString();    
    }
}
