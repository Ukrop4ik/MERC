using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner<T> where T : MonoBehaviour
{
    private readonly Transform _pool;
    private readonly Dictionary<string, T> _lookup = new Dictionary<string, T>();

    public Spawner(Transform pool, List<T> prototypes)
    {
        _pool = pool;
        foreach (var x in prototypes)
            _lookup[x.gameObject.name] = x;
    }

    public T Spawn(string name)
    {
        // TODO: implement cache
        return GameObject.Instantiate(_lookup[name].gameObject, _pool).GetComponent<T>();
    }

}
