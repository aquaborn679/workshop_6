using UnityEngine;

public class CubeGameController : MonoBehaviour
{
    public Rigidbody cube1, cube2, cube3;
    public GameObject winText;
    public int correctCubeIndex = 1; // от 1 до 3

    public void SelectCube(int index)
    {
        Debug.Log("Pressed: " + index); 

        cube1.useGravity = index != 1;
        cube2.useGravity = index != 2;
        cube3.useGravity = index != 3;

        if (index == correctCubeIndex)
            winText.SetActive(true);
    }

}
