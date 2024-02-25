using System.Collections;
using UnityEngine;

public class CPUStressTest : MonoBehaviour
{
    // Adjust these values to increase or decrease the stress levels
    private int[] stressLevels = new int[] { 1000, 10000, 100000, 100000, 1000000 };

    public void StressCpuButton(int level)
    {
        if (level > stressLevels.Length-1)
        {
            Debug.LogError("DEBUG::Stress Level out of range.");
            return;
        }
        StartCoroutine(StressCPU(stressLevels[level]));
        Debug.Log($"DEBUG::CPU Stress Test Started. stressLevels[{level}]");
    }

    /// <summary>
    /// The StressCPU coroutine in Unity is designed to simulate a heavy workload on the CPU for testing purposes
    /// </summary>
    private IEnumerator StressCPU(int iterations)
    {
        yield return new WaitForSeconds(3);
        Debug.Log($"DEBUG::Starting CPU Stress Test with {iterations} iterations.");
        for (int i = 0; i < iterations; i++)
        {
            GameObject go = Instantiate(gameObject, Vector3.zero, Quaternion.identity);
            go.AddComponent<Rigidbody2D>();
            Destroy(go, 3);
        }
        Debug.Log("DEBUG::CPU Stress Test Completed.");
    
        yield return null;
    }
    
}