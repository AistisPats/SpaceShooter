using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public int bullets, reloadTime, maxBullets;
    public TextMeshProUGUI bulletCount;
    public TextMeshProUGUI bulletCoolDown;
    public GameObject bullet;
    public Transform bulletShootPoint;
    private float lastReloadTime = 0f;

    void Start()
    {
        bulletCount.text = bullets.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(bullets < maxBullets)
        {
            if (reloadTime - Time.time + lastReloadTime > 0) bulletCoolDown.text = (reloadTime - Time.time + lastReloadTime).ToString();
            else bulletCoolDown.text = "0";
        }
        else  bulletCoolDown.text = "0";

        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            if(bullets > 0)
            {
                shoot();
                bullets--;
            }
        }
        if(Time.time- lastReloadTime > reloadTime)
        {
            if(bullets < maxBullets)bullets++;
            lastReloadTime= Time.time;
        }

        bulletCount.text = bullets.ToString();


    }

    private void shoot()
    {
        var a = Instantiate(bullet, bulletShootPoint.position, transform.rotation);
   
    }
}
