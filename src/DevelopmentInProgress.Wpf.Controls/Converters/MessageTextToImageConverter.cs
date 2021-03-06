﻿//-----------------------------------------------------------------------
// <copyright file="MessageTextToImageConverter.cs" company="Development In Progress Ltd">
//     Copyright © Development In Progress Ltd 2013. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace DevelopmentInProgress.Wpf.Controls.Converters
{
    /// <summary>
    /// Converts the message type to the image to display for the message.
    /// </summary>
    public sealed class MessageTextToImageConverter : IValueConverter
    {
        private ResourceDictionary resourceDictionary;

        public ResourceDictionary ResourceDictionary
        {
            get { return resourceDictionary; }
            set { resourceDictionary = value; }
        }

        /// <summary>
        /// Converts the value to the converted type.
        /// </summary>
        /// <param name="value">The value to evaluate.</param>
        /// <param name="targetType">The target type.</param>
        /// <param name="parameter">The parameter.</param>
        /// <param name="culture">The culture information.</param>
        /// <returns>A converted type.</returns>
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }

            try
            {
                if(parameter != null)
                {
                    value += parameter.ToString();
                }

                string image = value.ToString();
                switch (image.ToLower())
                {
                    case "clipboard":
                        return
                            new BitmapImage(new Uri($@"..\Images\{image.ToLower()}.png", UriKind.RelativeOrAbsolute));
                    default:
                        return ResourceDictionary[image.ToLower()];
                }
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Converts the value back to the converted type.
        /// </summary>
        /// <param name="value">The value to evaluate.</param>
        /// <param name="targetType">The target type.</param>
        /// <param name="parameter">The parameter.</param>
        /// <param name="culture">The culture information.</param>
        /// <returns>A converted type.</returns>
        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}