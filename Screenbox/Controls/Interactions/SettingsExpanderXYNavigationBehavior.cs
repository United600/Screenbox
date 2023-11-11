﻿using CommunityToolkit.WinUI;
using CommunityToolkit.WinUI.Behaviors;
using CommunityToolkit.WinUI.Controls;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace Screenbox.Controls.Interactions;
internal class SettingsExpanderXYNavigationBehavior : BehaviorBase<SettingsExpander>
{
    public Control? XYFocusRight { get; set; }

    protected override void OnAssociatedObjectLoaded()
    {
        base.OnAssociatedObjectLoaded();
        if (XYFocusRight == null) return;
        if (AssociatedObject.FindDescendant<ToggleButton>() is { } button)
        {
            button.XYFocusRight = XYFocusRight;
            XYFocusRight.XYFocusRight = button;
        }
    }
}
