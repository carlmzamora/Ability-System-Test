using UnityEditor;
using UnityEngine;
using static UnityEngine.GridBrushBase;

//[CustomEditor(typeof(AbilityHolder))]
public class AbilityHolderDrawer : Editor
{
    // this are serialized variables in YourClass
    SerializedProperty isMouseAbility;
    SerializedProperty key;
    SerializedProperty mouseCode;


    private void OnEnable()
    {
        isMouseAbility = serializedObject.FindProperty("isMouseAbility");
        key = serializedObject.FindProperty("key");
        mouseCode = serializedObject.FindProperty("mouseCode");
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        serializedObject.Update();
        EditorGUILayout.PropertyField(isMouseAbility);

        if (isMouseAbility.boolValue)
        {
            EditorGUILayout.PropertyField(mouseCode);
        }
        else
        {
            EditorGUILayout.PropertyField(key);
        }

        // must be on the end.
        serializedObject.ApplyModifiedProperties();
    }
}