using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpExample : MonoBehaviour
{
    public Transform SquareTransform1;
    public Transform SquareTransform2;
    [Range(0,5)]
    public float SquareSpeed;

    public Transform CircleTransform1;
    public Transform CircleTransform2;
    [Range(0,5)]
    public float CircleSpeed;

    public Transform HexagonTransform1;
    public Transform HexagonTransform2;
    [Range(0,5)]
    public float HexagonSpeed;
  
    void Update()
    {
      
        if(SquareTransform1.position.y<1){
            SquareTransform1.position = new Vector3(-20,33,0);
            SquareTransform2.position = new Vector3(-20,-33,0);
        }
        if(CircleTransform1.position.y<1){
            CircleTransform1.position = new Vector3(0,33,0);
            CircleTransform2.position = new Vector3(0,-33,0);
        }
        if(HexagonTransform1.position.y < 1){
            HexagonTransform1.position = new Vector3(20,33,0);
            HexagonTransform2.position = new Vector3(20,-33,0);
        }
        SquareTransform1.position = Vector3.Lerp(SquareTransform1.position,SquareTransform2.position,SquareSpeed * Time.deltaTime);
        SquareTransform2.position = Vector3.Lerp(SquareTransform2.position,SquareTransform1.position,SquareSpeed * Time.deltaTime);

        CircleTransform1.position = Vector3.Lerp(CircleTransform1.position,CircleTransform2.position,CircleSpeed * Time.deltaTime);
        CircleTransform2.position = Vector3.Lerp(CircleTransform2.position,CircleTransform1.position,CircleSpeed * Time.deltaTime);

        HexagonTransform1.position = Vector3.Lerp(HexagonTransform1.position,HexagonTransform2.position,HexagonSpeed * Time.deltaTime);
        HexagonTransform2.position = Vector3.Lerp(HexagonTransform2.position,HexagonTransform1.position,HexagonSpeed * Time.deltaTime);




    }
}
