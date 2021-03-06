﻿namespace StockTraderTransaq.InteractionWindowViews
{
	using MahApps.Metro.SimpleChildWindow;
	using System.Windows;

	/// <summary>
	/// Interaction logic for NotificationDialogWindow.xaml
	/// </summary>
	public partial class NotificationDialogWindow : ChildWindow
	{
		public static readonly DependencyProperty OkContentProperty =
			DependencyProperty.Register(
				"OkContent",
				typeof(object),
				typeof(NotificationDialogWindow),
				new PropertyMetadata(null));

		public object OkContent
		{
			get { return GetValue(OkContentProperty); }
			set { SetValue(OkContentProperty, value); }
		}

		public NotificationDialogWindow()
		{
			InitializeComponent();

            OkButton.Visibility = System.Windows.Visibility.Collapsed;
		}

		protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);

			if (e.Property == OkContentProperty)
			{
                if (OkContent != null)
                {
                    OkButton.Visibility = Visibility.Visible;
                    OkButton.Content = OkContent;
                }
			}
		}
	}
}
