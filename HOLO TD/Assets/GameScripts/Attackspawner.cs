using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.Windows.Speech;

public class Attackspawner : MonoBehaviour
{
    [SerializeField]
    Transform _destination;

    NavMeshAgent _navMeshAgent;

    public string resetCommand = "reset";

    private KeywordRecognizer keywordRecognizer;




    // Use this for initialization
    void Start()
    {


        keywordRecognizer = new KeywordRecognizer(new[] { resetCommand });
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();

        _navMeshAgent = this.GetComponent<NavMeshAgent>();


    }


    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        string cmd = args.text;



        // If user said "reset", reload the Unity scene to start from the beginning
        if (cmd == resetCommand)
        {
            SceneManager.LoadSceneAsync(0, LoadSceneMode.Single);
        }
    }

    void Update()
    {

        _navMeshAgent = this.GetComponent<NavMeshAgent>();

        if (_destination != null)
        {
            Vector3 targetVector = _destination.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
    }
}

