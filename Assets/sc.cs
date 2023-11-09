using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;


public class sc : MonoBehaviour
{
    public AudioClip[] sesler;
    public static collider col = new collider();
    public AudioClip audio0;
    public AudioClip audio1;
    public AudioClip audio2;
    public AudioClip audio3;
    public AudioClip audio4;
    public AudioClip audio5;
    public AudioClip audio6;
    public AudioClip audio7;
    public AudioClip audio8;
    public AudioClip audio9;
    public AudioClip audio10;
    public int[] dizi = new int[0];
    public int randomTagNumber;
    public int randoma; 
    public AudioSource audioSource;
    
  
    void Start()
    {
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        randoma = Random.Range(0, 10); // 0 ile 9 aras�nda rastgele bir say� olu�turur.
        Array.Resize(ref dizi, dizi.Length + 1);
        dizi[0] = randoma;
        randomTagNumber = randoma;
        sayiKontrol();
        

    }
    private void OnCollisionEnter(Collision other)

    {
        if (other.gameObject.tag == randomTagNumber.ToString())
        {
            // Objeyi 3 saniyeliğine kapat
            other.gameObject.SetActive(false);
            sayiOlustur();


            // 3 saniye sonra objeyi geri aç
            StartCoroutine(ActivateAfterDelay(other.gameObject, 3f));
        }

        // 3 saniye sonra objeyi geri açan işlem
        IEnumerator ActivateAfterDelay(GameObject obj, float delay)
        {
            yield return new WaitForSeconds(delay);
            obj.SetActive(true);

        
    }
    }
    // Update is called once per frame
    void Update()
    {

    }
    public int eski;

    public void sayiOlustur()
    {
        eski = randomTagNumber;
        randomTagNumber = Random.Range(0, 10); // 0 ile 9 aras�nda rastgele bir say� olu�turur.

        sayiKontrol();
    }
    public void sayiKontrol()
    {
        
        
        if (randomTagNumber==eski)
        {
            sayiOlustur();
        }
        else
        {
            sescal();

        }

    }
    public void sescal()
        {
        
            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }
            if (randomTagNumber == 0)
            {
                audioSource.clip = audio0;
                audioSource.Play();
            }
            else if (randomTagNumber == 1)
            {
                audioSource.clip = audio1;
                audioSource.Play();
            }
            else if (randomTagNumber == 2)
            {
                audioSource.clip = audio2;
                audioSource.Play();
            }
            else if (randomTagNumber == 3)
            {
                audioSource.clip = audio3;
                audioSource.Play();
            }
            else if (randomTagNumber == 4)
            {
                audioSource.clip = audio4;
                audioSource.Play();
            }
            else if (randomTagNumber == 5)
            {
                audioSource.clip = audio5;
                audioSource.Play();
            }
            else if (randomTagNumber == 6)
            {
                audioSource.clip = audio6;
                audioSource.Play();
            }
            else if (randomTagNumber == 7)
            {
                audioSource.clip = audio7;
                audioSource.Play();
            }
            else if (randomTagNumber == 8)
            {
                audioSource.clip = audio8;
                audioSource.Play();
            }
            else if (randomTagNumber == 9)
            {
                audioSource.clip = audio9;
                audioSource.Play();
            }
        }
    } 
