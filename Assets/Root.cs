using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField] private GameObject _cellPrefab;
    [SerializeField] private int _radius;

    private void Awake()
    {
        new HexagonArenaGenerator(_cellPrefab, _radius).Generate();
    }
}
