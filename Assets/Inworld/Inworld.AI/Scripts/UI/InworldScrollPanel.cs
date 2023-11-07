﻿/*************************************************************************************************
 * Copyright 2022 Theai, Inc. (DBA Inworld)
 *
 * Use of this source code is governed by the Inworld.ai Software Development Kit License Agreement
 * that can be found in the LICENSE.md file or at https://www.inworld.ai/sdk-license
 *************************************************************************************************/

using System.Collections.Generic;
using UnityEngine;

namespace Inworld.UI
{
    public class InworldScrollPanel : MonoBehaviour
    {
        [SerializeField] RectTransform m_ContentAnchor;
        readonly protected Dictionary<string, InworldUIElement> m_Bubbles = new Dictionary<string, InworldUIElement>();
        
        
    }
}
