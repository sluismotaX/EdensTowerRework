using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesRain : MonoBehaviour
{
    public GameObject[] _RandomObjects;
    public GameObject _UniqueObject = null;
    float _lastTime = 0, _nextTime;
    Vector3 _startingPos = new Vector3(0, 0f);
    public float  minx = 59f, maxx = 74f;
    public float minTime = 0.2f, maxTime = 0.6f;
    int aux = 0;
    public int cantidadTrampas = 0;
    public bool _Random = false; 
    void Start()
    {
        _nextTime = GetNextTime();
    }
    
    // Update is called once per frame
    void Update()
    {
        if(_Random == false && Time.time > _nextTime && aux < cantidadTrampas && _UniqueObject.tag != "Lava")
        {
            
            _startingPos.y = gameObject.transform.position.y;
            _startingPos.z = 0;
            _startingPos.x = GameObject.Find("Player").GetComponent<Transform>().position.x;
            Instantiate(_UniqueObject, _startingPos, Quaternion.identity);
            _nextTime = GetNextTime();
            aux++;
        }
        else
        if (Time.time > _nextTime && aux < cantidadTrampas && _Random == true)
        {
            _startingPos.x = Random.Range(maxx, minx);
            Instantiate(_RandomObjects[Random.Range(0,2)], _startingPos, Quaternion.identity);
            _nextTime = GetNextTime();
            aux++;
        }else if(_Random == false && Time.time > _nextTime && aux < cantidadTrampas && _UniqueObject.tag == "Lava")
        {
            Instantiate(_UniqueObject, gameObject.transform.position, Quaternion.identity);
            _nextTime = GetNextTime();
            aux++;
        }

    }

    float GetNextTime()
    {
        return Time.time + Random.Range(minTime, maxTime);
    }
}
