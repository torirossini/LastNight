﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName="TMPStory",menuName="TMPStory",order=1)]

[Serializable]public class TMPStory : ScriptableObject
{
	
	public Ui.Dialogue.DialogueContaining[] TmpDialogues;
	
	
}