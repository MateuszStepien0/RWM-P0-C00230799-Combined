using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinedFilter : MonoBehaviour
{
    public static int[] combinedFilter(int[] xs)
    {
        return ModuloFirstFilter.results(XOR21.XORcalculation(xs));
    }
}
