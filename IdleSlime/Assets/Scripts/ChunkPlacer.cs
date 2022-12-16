using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkPlacer : MonoBehaviour
{
    [SerializeField] private Transform[] _chunkTransforms;
    [SerializeField] private float SPEED = 0.1f;

    [SerializeField] private Vector2 _speed = new Vector2(0.1f, 0);

    const float DISTANSE_BTW_CHUNKS = 50f;

    private void FixedUpdate()
    {
        MoveChunks();
    }

    private void MoveChunks()
    {
        for (int i = 0; i < _chunkTransforms.Length; i++)
        {
            //Transform chunk = _chunkTransforms[i];
            //chunk.Translate(-_speed);
            _chunkTransforms[i].Translate(-_speed);
            if (_chunkTransforms[i].position.x < -DISTANSE_BTW_CHUNKS)
            {
                Vector2 pos = _chunkTransforms[i].position;
                pos.x += DISTANSE_BTW_CHUNKS * _chunkTransforms.Length;
                _chunkTransforms[i].position = pos;
            }
        }
    }
}
