using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.ShaderGraph;

public class CustomLightNode : CodeFunctionNode
{
    public override bool hasPreview { get => false; }
    protected override MethodInfo GetFunctionToConvert()
    {

    };

}
