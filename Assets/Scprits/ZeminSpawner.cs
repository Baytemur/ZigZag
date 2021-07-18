using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminSpawner : MonoBehaviour
{
    public GameObject son_zemin;

    void Start ()
    {
        for (int i = 0; i < 15; i++)
        {
            zemin_oluştur();
            i++;
        }
    }

    public void zemin_oluştur()
    {
        Vector3 yön;
        //Bana bir rastgele değer oluştur bu değer 0 ya da 1 olsun
        if(Random.Range(0,2) == 0)
        {
            yön = Vector3.left;
        }
        else
        {
            yön = Vector3.forward;
        }
        son_zemin = Instantiate(son_zemin, son_zemin.transform.position + yön, son_zemin.transform.rotation);
    }
}
