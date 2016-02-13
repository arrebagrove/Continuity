﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Continuity.Controls
{
    public sealed class TabItem : ContentControl
    {
        public TabItem()
        {
            DefaultStyleKey = typeof(TabItem);
        }

        #region Properties

        public object Header
        {
            get { return GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register("Header", typeof(object), typeof(TabItem), new PropertyMetadata(null, (s, dp) =>
            {
                var value = dp.NewValue;
                if (value is string)
                {
                    var self = ((TabItem)s);
                    self.Header = self.Header.ToString().ToUpperInvariant();
                }
            }));

        #endregion
    }
}
