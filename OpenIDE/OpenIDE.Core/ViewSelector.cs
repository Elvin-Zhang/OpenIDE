﻿using OpenIDE.Core.Contracts;
using OpenIDE.Core.Extensibility;
using OpenIDE.Core.Views;

namespace OpenIDE.Core
{
    public class ViewSelector
    {
        public static View Select(ItemTemplate it, byte [] data)
        {
            if(it.View != null)
            {
                it.View.Data = data;
                it.View.Create(data);

                return it.View;
            }
            else
            {
                var v = new EditorView(it);
                v.Data = data;
                v.Create(data);

                return v;
            }
        }
    }
}