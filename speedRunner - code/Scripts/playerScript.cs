//Kullandığınız versiyon  Solondis Digital tarafından geliştirilmiş Developer Beta sürümüdür.
//Gerekli bilgilendirmeler kod satırlarının sonunda mevcuttur.
using System.Collection;
using System.Collection.Generic;
using UnityEngine;

public class playerScript : MonoBehavior
{
    public float speed;
    bool changePosition, startGame;
    public GameObject rightPosition, leftPosition, deadPrefab;
    
//Start bölümü boş kalsın
    void Start(){}

    void Update()
    {

        GetComponent<Rigidbody>().AddForce(Vector3.forward * speed * Tme.deltaTime);
//karakter sağ sol animasyon yumuşaklığı ayarı (10f yazan bölüm)
        if(changePosition == true && startGame == true)
        {
            
            transform.position =  Vector3.Lerp(transform.position,new Vector3(rightPosition
            .transform.position.X, transform.position.y transform.position.z), 10f * Time.deltaTime );

        }

        if(changePosition == false && startGame == true)
        {
            
            transform.position =  Vector3.Lerp(transform.position,new Vector3(leftPosition
            .transform.position.X, transform.position.y transform.position.z), 10f * Time.deltaTime );

        }

        if (Input.GetMauseButtonDown(0))
        {
            startGame = true;

            if(changePosition === false)
            {
                changePosition = true;
            }
            else if(changePosition == true)
            {
                changePosition = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "wall")
        {

            transform.GameObject.SetActive(false);
            for (int i = 0; i < 17; i++)
            {
                Instantiate(deadPrefab, transform.position, Quaternion.idenity);
            }
        }
//Bölüm bitişi console bölümünden takip edilecek...
        if(other.tag=="finish")
        {
             Debug.Log("Finish");
        }
    }
}

//Bu kodların kullanımı gelştirici kesim için serbest olum 3.kişilerin veya kuruluşların kulanımına kapalıdır.
//Kodların kullanımı ve tanımlanması hakları Solondis Digital içerisinde saklıdır.
//Şirket geliştiricileri hariç 3.parti kullanıcıların şirketten izin almadan kullanımı halinde Solondis Digtal haklarını kullanma  hürriyetine sahiptir.
//Kodların ek bir programda kullanımı halinde "//" içerisinde Solondis Digital 2020(C) ibaresi kullanımı zorunludur.
//Aksi takdirde 3. satırdaki belirtilen maddeler uygulanacaklardır.
//Solondis Digital 2020(C)
// Developer: Kağan Yusuf Arslan, Talha Kocapınar.