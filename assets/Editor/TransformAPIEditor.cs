
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(TransformAPIs))]
public class TransformAPIEditor : Editor {
    public override void OnInspectorGUI() {
        EditorGUILayout.HelpBox("通过查询Transform API 文档了解更多API 使用方法:https://docs.unity3d.com/ScriptReference/Transform.html ",MessageType.Info);
        if(GUILayout.Button("打开文档页面")){
            Application.OpenURL("https://docs.unity3d.com/ScriptReference/Transform.html");
        }
        base.OnInspectorGUI();
    }

}
