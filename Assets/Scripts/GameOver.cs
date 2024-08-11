using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] Score score;
    [SerializeField] PanelContlloler panelcontlloler;
    private void Start()
    {
        score= GameObject.Find("score").GetComponent<Score>();
        panelcontlloler = GameObject.FindWithTag("Player").GetComponent<PanelContlloler>();
    }
    //Õ“Ë‚µ‚½ê—p‚ÌŠÖ”‚ğì‚é

    void OnCollisionEnter(Collision co)
    {
        if (co.gameObject.tag == "fruats")
        {
            score.PlayScore();
            panelcontlloler.Result();
            Destroy(this.gameObject);
        }

    }


}
