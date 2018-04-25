namespace PPE3_Daltons.Assets
{
    using System;
    using System.Net;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Ink;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Animation;
    using System.Windows.Shapes;

    /// <summary>
    /// Converter qui permet de rendre visible ce qui est faux.
    /// </summary>
    public class FalseIsVisibleConverter : IValueConverter
    {
        /// <summary>
        /// Convertit ce qui est faux.
        /// </summary>
        /// <param name="value">La valeur de type objet.</param>
        /// <param name="targetType">Le type de la cible.</param>
        /// <param name="parameter">Le paramètre de type objet.</param>
        /// <param name="culture">La culture de  l'utilisateur.</param>
        /// <returns>Visibilité de ce qui est faux.</returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
            {
                return Visibility.Collapsed;
            }

            try
            {
                if ((bool)value)
                {
                    return Visibility.Collapsed;
                }
                else
                {
                    return Visibility.Visible;
                }
            }
            catch
            {
                return Visibility.Collapsed;
            }
        }

        /// <summary>
        /// Convertion inverse de ce qui est faux.
        /// </summary>
        /// <param name="value">La valeur de type objet.</param>
        /// <param name="targetType">Le type de la cible.</param>
        /// <param name="parameter">Le paramètre de type objet.</param>
        /// <param name="culture">La culture de  l'utilisateur.</param>
        /// <returns>La valeur à passer à l'objet source.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
