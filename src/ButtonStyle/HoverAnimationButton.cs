﻿using System.Windows;
using System.Windows.Controls;

namespace ButtonStyle
{
    public class HoverAnimationButton : Button
    {
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue (CornerRadiusProperty); }
            set { SetValue (CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register ("CornerRadius", typeof (CornerRadius), typeof (HoverAnimationButton), new PropertyMetadata (new CornerRadius(0)));


        static HoverAnimationButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (HoverAnimationButton), new FrameworkPropertyMetadata (typeof (HoverAnimationButton)));
        }
    }
}