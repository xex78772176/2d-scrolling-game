using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapCreate : MonoBehaviour
{
    public GameObject mapPrefab;
    public GameObject mapPrefab2;
    public GameObject Endpoint;
    private GameObject nextMap;

    public GameObject Gingerpoint1;
    public GameObject Gingerpoint2;
    public GameObject Gingerpoint3;
    public GameObject Gingerpoint4;
    public GameObject Gingerpoint5;
    public GameObject Gingerpoint6;
    public GameObject Gingerpoint7;
    public GameObject Gingerpoint8;
    public GameObject Gingerpoint9;
    public GameObject Gingerpoint10;
    public GameObject Gingerpoint11;
    public GameObject Gingerpoint12;
    public GameObject Gingerpoint13;
    public GameObject Gingerpoint14;
    public GameObject ginger;
    private int level;





    void Awake()
    {

        level = PlayerPrefs.GetInt("level");
        Instantiate(ginger, Gingerpoint1.transform.position, Gingerpoint1.transform.rotation);
        Instantiate(ginger, Gingerpoint2.transform.position, Gingerpoint2.transform.rotation);
        Instantiate(ginger, Gingerpoint3.transform.position, Gingerpoint3.transform.rotation);
        Instantiate(ginger, Gingerpoint4.transform.position, Gingerpoint4.transform.rotation);
        Instantiate(ginger, Gingerpoint5.transform.position, Gingerpoint5.transform.rotation);
        Instantiate(ginger, Gingerpoint6.transform.position, Gingerpoint6.transform.rotation);
        Instantiate(ginger, Gingerpoint7.transform.position, Gingerpoint7.transform.rotation);

    }








    void OnTriggerEnter2D(Collider2D other)
    {
        if (level == 1)
        {
           

           
   nextMap = GameObject.Instantiate(mapPrefab, Endpoint.transform.position, Endpoint.transform.rotation) as GameObject;
            


            Vector3 pos = Endpoint.transform.position;
            pos.x -= 55;
            Endpoint.transform.position = pos;


            Vector3 newgingerpos1 = Gingerpoint1.transform.position;
            newgingerpos1.x -= 55;
            Gingerpoint1.transform.position = newgingerpos1;

            Vector3 newgingerpos2 = Gingerpoint2.transform.position;
            newgingerpos2.x -= 55;
            Gingerpoint2.transform.position = newgingerpos2;

            Vector3 newgingerpos3 = Gingerpoint3.transform.position;
            newgingerpos3.x -= 55;
            Gingerpoint3.transform.position = newgingerpos3;

            Vector3 newgingerpos4 = Gingerpoint4.transform.position;
            newgingerpos4.x -= 55;
            Gingerpoint4.transform.position = newgingerpos4;

            Vector3 newgingerpos5 = Gingerpoint5.transform.position;
            newgingerpos5.x -= 55;
            Gingerpoint5.transform.position = newgingerpos5;

            Vector3 newgingerpos6 = Gingerpoint6.transform.position;
            newgingerpos6.x -= 55;
            Gingerpoint6.transform.position = newgingerpos6;

            Vector3 newgingerpos7 = Gingerpoint7.transform.position;
            newgingerpos7.x -= 55;
            Gingerpoint7.transform.position = newgingerpos7;



                Instantiate(ginger, Gingerpoint1.transform.position, Gingerpoint1.transform.rotation);
                Instantiate(ginger, Gingerpoint2.transform.position, Gingerpoint2.transform.rotation);
                Instantiate(ginger, Gingerpoint3.transform.position, Gingerpoint3.transform.rotation);
                Instantiate(ginger, Gingerpoint4.transform.position, Gingerpoint4.transform.rotation);
                Instantiate(ginger, Gingerpoint5.transform.position, Gingerpoint5.transform.rotation);
                Instantiate(ginger, Gingerpoint6.transform.position, Gingerpoint6.transform.rotation);
                Instantiate(ginger, Gingerpoint7.transform.position, Gingerpoint7.transform.rotation);
            

          
        }





        if (level == 2)
        {
            int map = Random.Range(0, 10);

            if (map % 2 == 0)
            {
                nextMap = GameObject.Instantiate(mapPrefab, Endpoint.transform.position, Endpoint.transform.rotation) as GameObject;
            }
            else if (map % 2 == 1)
            {

                nextMap = GameObject.Instantiate(mapPrefab2, Endpoint.transform.position, Endpoint.transform.rotation) as GameObject;
                nextMap.SetActive(true);
            }

            Vector3 pos = Endpoint.transform.position;
            pos.x -= 55;
            Endpoint.transform.position = pos;


            Vector3 newgingerpos1 = Gingerpoint1.transform.position;
            newgingerpos1.x -= 55;
            Gingerpoint1.transform.position = newgingerpos1;

            Vector3 newgingerpos2 = Gingerpoint2.transform.position;
            newgingerpos2.x -= 55;
            Gingerpoint2.transform.position = newgingerpos2;

            Vector3 newgingerpos3 = Gingerpoint3.transform.position;
            newgingerpos3.x -= 55;
            Gingerpoint3.transform.position = newgingerpos3;

            Vector3 newgingerpos4 = Gingerpoint4.transform.position;
            newgingerpos4.x -= 55;
            Gingerpoint4.transform.position = newgingerpos4;

            Vector3 newgingerpos5 = Gingerpoint5.transform.position;
            newgingerpos5.x -= 55;
            Gingerpoint5.transform.position = newgingerpos5;

            Vector3 newgingerpos6 = Gingerpoint6.transform.position;
            newgingerpos6.x -= 55;
            Gingerpoint6.transform.position = newgingerpos6;

            Vector3 newgingerpos7 = Gingerpoint7.transform.position;
            newgingerpos7.x -= 55;
            Gingerpoint7.transform.position = newgingerpos7;


            Vector3 newgingerpos8 = Gingerpoint8.transform.position;
            newgingerpos8.x -= 55;
            Gingerpoint8.transform.position = newgingerpos8;

            Vector3 newgingerpos9 = Gingerpoint9.transform.position;
            newgingerpos9.x -= 55;
            Gingerpoint9.transform.position = newgingerpos9;

            Vector3 newgingerpos10 = Gingerpoint10.transform.position;
            newgingerpos10.x -= 55;
            Gingerpoint10.transform.position = newgingerpos10;

            Vector3 newgingerpos11 = Gingerpoint11.transform.position;
            newgingerpos11.x -= 55;
            Gingerpoint11.transform.position = newgingerpos11;

            Vector3 newgingerpos12 = Gingerpoint12.transform.position;
            newgingerpos12.x -= 55;
            Gingerpoint12.transform.position = newgingerpos12;

            Vector3 newgingerpos13 = Gingerpoint13.transform.position;
            newgingerpos13.x -= 55;
            Gingerpoint13.transform.position = newgingerpos13;

            Vector3 newgingerpos14 = Gingerpoint14.transform.position;
            newgingerpos14.x -= 55;
            Gingerpoint14.transform.position = newgingerpos14;




            if (map % 2 == 0)
            {



                Instantiate(ginger, Gingerpoint1.transform.position, Gingerpoint1.transform.rotation);
                Instantiate(ginger, Gingerpoint2.transform.position, Gingerpoint2.transform.rotation);
                Instantiate(ginger, Gingerpoint3.transform.position, Gingerpoint3.transform.rotation);
                Instantiate(ginger, Gingerpoint4.transform.position, Gingerpoint4.transform.rotation);
                Instantiate(ginger, Gingerpoint5.transform.position, Gingerpoint5.transform.rotation);
                Instantiate(ginger, Gingerpoint6.transform.position, Gingerpoint6.transform.rotation);
                Instantiate(ginger, Gingerpoint7.transform.position, Gingerpoint7.transform.rotation);
            }

            else if (map % 2 == 1)
            {


                Instantiate(ginger, Gingerpoint8.transform.position, Gingerpoint8.transform.rotation);
                Instantiate(ginger, Gingerpoint9.transform.position, Gingerpoint9.transform.rotation);
                Instantiate(ginger, Gingerpoint10.transform.position, Gingerpoint10.transform.rotation);
                Instantiate(ginger, Gingerpoint11.transform.position, Gingerpoint11.transform.rotation);
                Instantiate(ginger, Gingerpoint12.transform.position, Gingerpoint12.transform.rotation);
                Instantiate(ginger, Gingerpoint13.transform.position, Gingerpoint13.transform.rotation);
                Instantiate(ginger, Gingerpoint14.transform.position, Gingerpoint14.transform.rotation);


            }

        }








      


        Vector3 newcrePos = transform.position;
        newcrePos.x -= 55;
        transform.position = newcrePos;
        //Destroy(gameObject);

    }

    public void OnApplicationQuit()
    {
        Vector3 pos = Endpoint.transform.position;
        pos.x = -30;
        Endpoint.transform.position = pos;
    }

    void OnTriggerExit2D(Collider2D other)    {
        // Destroy everything that leaves the trigger
        
       // Destroy(currentPrefab);    }


}
