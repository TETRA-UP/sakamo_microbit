using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Dropper : MonoBehaviour
{
    //���������t���[�c���i�[����z����쐬
    [SerializeField] private GameObject[] fruitsPrefabs;

    //�t���[�c�𗎂Ƃ��I�u�W�F�N�g�̈ړ����x
    float speed = 0.05f;

    float defaultPos;
    [SerializeField]
    AudioClip sound;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
        defaultPos = transform.position.x;
        Pop();
    }

    void Update()
    {
        //�����Ɉړ��̃v���O�����������܂��傤
        float x = transform.position.x + speed;
        if(x>defaultPos+5f||x<defaultPos-5.0f)
        {
            speed *= -1;
        }
        transform.position=new Vector3(x, transform.position.y, transform.position.z);
    }
    public void Pop()
        
    {
        //�ϐ��̒��Ƀ����_���Ȑ������i�[���Ă���
        int randomlndex = UnityEngine.Random.Range(0, fruitsPrefabs.Length);
        //�t���[�c�̐���
        Instantiate(fruitsPrefabs[randomlndex], transform.position, Quaternion.identity, transform);
        audioSource.PlayOneShot(sound);
    }
}