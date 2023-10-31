using UnityEngine;

public class ChangeTag : MonoBehaviour
{
    public Material targetMaterial;

    private void Start()
    {
        GameObject[] objects = FindObjectsOfType<GameObject>();
        foreach (GameObject obj in objects)
        {
            if (obj.GetComponent<MeshRenderer>() != null && (obj.GetComponent<Renderer>().material.ToString() == "Prop (Instance) (UnityEngine.Material)")) {
                obj.tag = "Prop";
            }
            
        }
    }
}