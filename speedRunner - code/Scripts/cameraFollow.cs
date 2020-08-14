//Kullandığınız versiyon  Solondis Digital tarafından geliştirilmiş Developer Beta sürümüdür.
//Gerekli bilgilendirmeler kod satırlarının sonunda mevcuttur.
using System.Collection;
using System.Collection.Generic;
using UnityEngine;


public class cameraFollow : MonoBehaivor
{
    public GameObject player;

    public Start()
    {



    }

    public Update()
    {

        transform.position = new Vector3(transform.position.x, 
        transform.position.y, player.transform.position - 9f);

    }

}
//Bu kodların kullanımı gelştirici kesim için serbest olum 3.kişilerin veya kuruluşların kulanımına kapalıdır.
//Kodların kullanımı ve tanımlanması hakları Solondis Digital içerisinde saklıdır.
//Şirket geliştiricileri hariç 3.parti kullanıcıların şirketten izin almadan kullanımı halinde Solondis Digtal haklarını kullanma  hürriyetine sahiptir.
//Kodların ek bir programda kullanımı halinde "//" içerisinde Solondis Digital 2020(C) ibaresi kullanımı zorunludur.
//Aksi takdirde 3. satırdaki belirtilen maddeler uygulanacaklardır.
//Solondis Digital 2020(C)
// Developer: Kağan Yusuf Arslan, Talha Kocapınar.