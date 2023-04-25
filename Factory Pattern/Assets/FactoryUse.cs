using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryUse : MonoBehaviour
{
    private void Start()
    {
        CarStore carStore1 = CarFactory.createCar(CarType.Sedan);
        CarStore carStore2 = CarFactory.createCar(CarType.SuperCar);

        carStore1.Create();
        carStore2.Create();
    }

}
