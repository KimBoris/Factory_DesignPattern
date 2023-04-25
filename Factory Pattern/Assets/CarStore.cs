using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public abstract class CarStore : MonoBehaviour
{
    public GameObject sedan;
    public GameObject superCar;
    //public GameObject carStoreObj;
    public abstract void Create();
}


public class Sedan : CarStore
{
    public Sedan()
    {
        Debug.Log("트럭 생성!");
    }

    public override void Create()//차 생성
    {
        Instantiate(sedan, Vector3.zero, Quaternion.identity);
        Debug.Log("세단");
    }
}

public class SuperCar : CarStore
{
    public SuperCar()
    {
        Debug.Log("수퍼카 생성");
    }

    public override void Create()
    {
        Instantiate(superCar, Vector3.zero, Quaternion.identity);
        Debug.Log("수퍼카");
    }
}

