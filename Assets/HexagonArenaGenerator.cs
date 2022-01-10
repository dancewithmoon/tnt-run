using UnityEngine;

public class HexagonArenaGenerator
{
    private readonly GameObject _cellPrefab;
    private readonly int _radius;
    private readonly Vector3 _cellBounds;

    public HexagonArenaGenerator(GameObject cellPrefab, int radius)
    {
        _cellPrefab = cellPrefab;
        _radius = radius;
        _cellBounds = _cellPrefab.GetComponent<MeshFilter>().GetRealSize();
    }

    public void Generate()
    {
        Vector2 offset = GetOffset();
        var lastPosition = Vector3.zero;
        for (int i = _radius; i > _radius / 2; i--)
        {
            int order = _radius - i + 1;
            for (int j = 0; j < i; j++)
            {
                Object.Instantiate(_cellPrefab, lastPosition, Quaternion.identity);
                if (i < _radius)
                {
                    var tempPos = lastPosition;
                    tempPos.x *= -1;
                    Object.Instantiate(_cellPrefab, tempPos, Quaternion.identity);
                }
                lastPosition.z += _cellBounds.z;
            }
            lastPosition.x = offset.x * order;
            lastPosition.z = offset.y * order;
        }
    }

    private Vector2 GetOffset()
    {
        Hexagon hexagon = new Hexagon();
        hexagon.BigDiagonal = _cellBounds.x;
        Vector2 offset = new Vector2(hexagon.Side + hexagon.Side / 2, _cellBounds.z / 2);
        return offset;
    }
}

