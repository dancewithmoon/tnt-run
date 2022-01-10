using UnityEngine;

public static class MeshExtensions
{
    public static float GetRealHeight(this MeshFilter obj)
    {
        return obj.transform.localScale.y * obj.GetRealSize().y;
    }

    public static Vector3 GetRealSize(this MeshFilter obj)
    {
        return obj.sharedMesh.bounds.size;
    }
}

