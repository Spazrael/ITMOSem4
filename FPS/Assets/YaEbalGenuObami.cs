using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Services.Analytics;
using Unity.Services.Core;
using UnityEngine;

public class YaEbalGenuObami : MonoBehaviour {
    // Start is called before the first frame update
    async void Start() {
        await UnityServices.InitializeAsync();
        AnalyticsService.Instance.StartDataCollection();

        Debug.LogException(new Exception("Testing Cloud Diagnostics reports"));
    }
}