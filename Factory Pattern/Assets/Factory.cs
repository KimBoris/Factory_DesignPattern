using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CarType
{
    Sedan,
    SuperCar
}

public class CarFactory
{
    public static CarStore createCar(CarType type)
    {
        CarStore carStore = null;

        switch(type)
        {
            case CarType.Sedan:
                carStore = new Sedan();
                break;

            case CarType.SuperCar:
                carStore = new Sedan();
                break;
        }
        return carStore;
    }
}