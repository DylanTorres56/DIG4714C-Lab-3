using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    [SerializeField]
    string courseName;
    static int maxWeeks=12;
    //max amount of each is one per week, and there are 12 weeks
    [SerializeField][Range(1, 12)]
    int numModules, numReadings, numQuizzes, numAssignments;
    float moduleWeight = .15f, readingWeight = .30f, quizWeight = .15f, assignmentWeight = .30f;
   
    [SerializeField]
    bool hasTaught;

    float score=0;

    // Start is called before the first frame update
    void Start()
    {
        //math for creating the total difficulty
        score = (DifficultyWeightCalculator(numModules, moduleWeight) + DifficultyWeightCalculator(numReadings, readingWeight) + DifficultyWeightCalculator(numQuizzes, quizWeight) + DifficultyWeightCalculator(numAssignments, assignmentWeight) + (Convert.ToInt32(!hasTaught) * 0.10f))*10;
        print("Course Name: "+courseName+" | Diffuclty: "+ score.ToString("0.0"));
    }
    //basic calculation of the difficulty Weight of each group
    float DifficultyWeightCalculator(int number, float weight)
    {
        return ((float)number/maxWeeks)*weight;
    }
}
