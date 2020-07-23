using UnityEngine;

public class JazzUtil
{
    public static float SquareDistance(Vector3 a, Vector3 b)
    {
        float diffX = a.x - b.x;
        float diffY = a.y - b.y;
        float diffZ = a.z - b.z;
        return diffX * diffX + diffY * diffY + diffZ * diffZ;
    }
}